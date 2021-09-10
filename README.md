# Getting started with ATSAME70 and Forth
This $10 board is very compelling with a 300MHz Cortex M7 and high speed USB
out of the box, a feature not easily seen in other cheap MCUs:

[https://www.aliexpress.com/item/1005003173783268.html](https://www.aliexpress.com/item/1005003173783268.html)

Nevertheless, getting it to run took me quite some time, and I want to share how to get
going programming the board.

## Setting up the programming environment
### Getting a CMSIS-DAP probe
The board is best programmed with a CMSIS-DAP probe.
The quickest way to get a CMSIS-DAP probe is to flash this firmware onto
one of the cheap, ubiquitios STM32F103c8t6 boards (also known as the 'Blue Pill'):

[F103-DAP-SWO-CDC-BLUEPILL-SWD_REMAP.hex](https://github.com/RadioOperator/STM32F103C8T6_CMSIS-DAP_SWO/blob/master/build/F103-DAP-SWO-CDC-BLUEPILL-SWD_REMAP.hex)

The same repository also contains ready-made firmware for the cheap STLINK clones available.
Of course, you also can buy a ready-made CMSIS DAP probe for about $12 on AliExpress,
but the BluePill will cost significantly less.

### installing and setting up `pyocd`
Next we need an On-Chip-Debugger software. The easiest to use is [pyocd](https://github.com/pyocd/pyOCD),
which you install with:
```
pip3 install pyocd
```

After installation you already should be able to see your CMSIS-DAP probe:
```
$ pyocd list
  #   Probe                        Unique ID
-------------------------------------------------
  0   CMSIS-DAP by ARM CMSIS-DAP   0001A0000000
```

After connecting the four wires (3.3V, SWDCLK, SWDIO, GND) from the BluePill to the
target board you actually already can start using the probe:
```
$ pyocd commander
0000793:WARNING:board:Generic 'cortex_m' target type is selected by default; is this intentional?
You will be able to debug most devices, but not program  flash.
To set the target type use the '--target' argument or 'target_override' option.
Use 'pyocd list --targets' to see available targets types.

Connected to CoreSightTarget [Running]: 0001A0000000
pyocd> show graph
- <pyocd.board.board.Board object at 0x7faf9b5717f0>
  - <pyocd.coresight.coresight_target.CoreSightTarget object at 0x7faf9b571850>
    - <pyocd.coresight.cortex_m.CortexM object at 0x7faf98c045e0>
      - <pyocd.coresight.dwt.DWT object at 0x7faf98c04670>
      - <pyocd.coresight.fpb.FPB object at 0x7faf98c047f0>
      - <pyocd.coresight.itm.ITM object at 0x7faf98c2b2e0>
      - <pyocd.coresight.tpiu.TPIU object at 0x7faf98c04160>

pyocd> show target
Target:       CoreSightTarget
DAP IDCODE:   0x0bd11477
```
As the warning message suggests, you actually can already start looking around
in the memories of the target, and can even run a debug server, but without
complete target support you cannot:
* flash and erase the device
* set breakpoints and full debugger features

To accomplish this, we need to download the device support pack,
which you can download from the
[Microchip CMSIS packs download site](https://packs.download.microchip.com/),
searching for `SAME70` and scrolling down to the device entry.

I created a directory for downloaded CMSIS-packs in `/opt`, where I saved the downloaded pack:
```
$ ls /opt/cmsis-packs
Atmel.SAME70_DFP.2.4.166.atpack
```
This pack is actually a zip file and also contains complete board support for C/C++
(Header files, example code, linker scripts, SVD-files and pyocd plugin).

As soon you have the pack available, you can use it in pyocd:
```
$ pyocd commander  --pack /opt/cmsis-packs/Atmel.SAME70_DFP.2.4.166.atpack --target atsame70n19
Connected to ATSAME70N19 [Running]: 0001A0000000
pyocd> show target
Target:       ATSAME70N19
DAP IDCODE:   0x0bd11477
pyocd> show graph
- <pyocd.board.board.Board object at 0x7f37350e7760>
  - <pyocd.target.pack.pack_target.ATSAME70N19 object at 0x7f3732513df0>
    - <pyocd.coresight.cortex_m.CortexM object at 0x7f37323691c0>
      - <pyocd.coresight.dwt.DWT object at 0x7f3730246e50>
      - <pyocd.coresight.fpb.FPB object at 0x7f3732369160>
      - <pyocd.coresight.itm.ITM object at 0x7f37303f12e0>
      - <pyocd.coresight.tpiu.TPIU object at 0x7f3732370ac0>
pyocd> show map
 Region  Type   Start       End         Size        Access  Sector      Page
 IROM1   Flash  0x00400000  0x0047ffff  0x00080000  rx      0x00002000  0x00000200
 IROM2   Rom    0x00800000  0x00803fff  0x00004000  rx      -           -
 IRAM1   Ram    0x20400000  0x2043ffff  0x00040000  rwx     -           -
```
Now the debug probe can do anything we need to, including erasing, flashing,
debugging, setting breakpoints, etc. We are ready to go.

As this gets tedious easily, you can create a [pyocd.yaml](https://github.com/hansfbaier/mecrisp-stellaris-atsame70/blob/main/mecrisp-stellaris-source/atsame70-ra/pyocd.yaml)
file in the same directory of the firmware you like to flash.
In our case this is located in: `mecrisp-stellaris-source/atsame70-ra/pyocd.yaml`:
```yaml
probes:
  0001A0000000:
    target_override:  atsame70n19
    test_binary:      mecrisp-stellaris-atsame70n19.bin

pack:
  - /opt/cmsis-packs/Atmel.SAME70_DFP.2.4.166.atpack
```

### building and flashing mecrisp FORTH onto the target
As now everything is set up and ready, we build the firmware:
```bash
$ make
arm-none-eabi-as -g mecrisp-stellaris-atsame70n19.s -o mecrisp-stellaris-atsame70n19.o
arm-none-eabi-ld -g -o mecrisp-stellaris-atsame70n19.elf -T memmap mecrisp-stellaris-atsame70n19.o
arm-none-eabi-objdump -D mecrisp-stellaris-atsame70n19.elf > mecrisp-stellaris-atsame70n19.list
arm-none-eabi-objcopy mecrisp-stellaris-atsame70n19.elf mecrisp-stellaris-atsame70n19.bin -O binary
arm-none-eabi-objdump --source --all-headers --demangle --line-numbers --wide mecrisp-stellaris-atsame70n19.elf > mecrisp-stellaris-atsame70n19.lst
arm-none-eabi-objcopy -I binary -O ihex mecrisp-stellaris-atsame70n19.bin mecrisp-stellaris-atsame70n19.hex

$ pyocd erase --chip
0001266:INFO:eraser:Erasing chip...
0003265:INFO:eraser:Done

$ pyocd flash mecrisp-stellaris-atsame70n19.elf
[====================] 100%
0003918:INFO:loader:Erased 24576 bytes (3 sectors), programmed 24576 bytes (48 pages), skipped 0 bytes (0 pages) at 9.35 kB/s
```
The chip erase above would strictly have been necessary, because, as you
can see the `flash` command does the erase automatically.
It is, however, a nice way to get a clean slate if the MCU got messed up
somehow.

Then mecrisp FORTH is ready to use:
```
$ picocom -b 500000 /dev/ttyUSB0 --imap lfcrlf,crcrlf --omap delbs,crlf --send-cmd "ascii-xfr -s -l 80 -n"
picocom v3.1

port is        : /dev/ttyUSB0
flowcontrol    : none
baudrate is    : 500000
parity is      : none
databits are   : 8
stopbits are   : 1
escape is      : C-a
local echo is  : no
noinit is      : no
noreset is     : no
hangup is      : no
nolock is      : no
send_cmd is    : ascii-xfr -s -l 80 -n
receive_cmd is : rz -vv -E
imap is        : crcrlf,lfcrlf,
omap is        : crlf,delbs,
emap is        : crcrlf,delbs,
logfile is     : none
initstring     : none
exit_after is  : not set
exit is        : no

Type [C-a] [C-h] to see available commands
Terminal ready
  ok.
  ok.
reset Mecrisp-Stellaris RA 2.5.9 for SAME70N19 by Matthias Koch
```

`picocom` is nice for getting started quickly, but it lacks support for forth
files incluing other forth files. If you need that, `e4thcom` is recommended:
[https://wiki.forth-ev.de/doku.php/en:projects:e4thcom](https://wiki.forth-ev.de/doku.php/en:projects:e4thcom)

This concludes the introduction.

Have fun!




