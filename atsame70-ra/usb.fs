$40038000 constant USBHS ( USB High-Speed Interface )
USBHS $0000 + constant USBHS-DEVCTRL ( Device General Control Register )
USBHS $0004 + constant USBHS-DEVISR ( Device Global Interrupt Status Register )
USBHS $0008 + constant USBHS-DEVICR ( Device Global Interrupt Clear Register )
USBHS $000C + constant USBHS-DEVIFR ( Device Global Interrupt Set Register )
USBHS $0010 + constant USBHS-DEVIMR ( Device Global Interrupt Mask Register )
USBHS $0014 + constant USBHS-DEVIDR ( Device Global Interrupt Disable Register )
USBHS $0018 + constant USBHS-DEVIER ( Device Global Interrupt Enable Register )
USBHS $001C + constant USBHS-DEVEPT ( Device Endpoint Register )
USBHS $0020 + constant USBHS-DEVFNUM ( Device Frame Number Register )
USBHS $100 + constant USBHS-DEVEPTCFG-BASE ( Device Endpoint Configuration Register n )
USBHS $130 + constant USBHS-DEVEPTISR-BASE ( Device Endpoint Status Register n )
USBHS $160 + constant USBHS-DEVEPTICR-BASE ( Device Endpoint Clear Register n )
USBHS $190 + constant USBHS-DEVEPTIFR-BASE ( Device Endpoint Set Register n )
USBHS $1C0 + constant USBHS-DEVEPTIMR-BASE ( Device Endpoint Mask Register n )
USBHS $1F0 + constant USBHS-DEVEPTIER-BASE ( Device Endpoint Enable Register n )
USBHS $220 + constant USBHS-DEVEPTIDR-BASE ( Device Endpoint Disable Register n )
USBHS $0400 + constant USBHS-HSTCTRL ( Host General Control Register )
USBHS $0404 + constant USBHS-HSTISR ( Host Global Interrupt Status Register )
USBHS $0408 + constant USBHS-HSTICR ( Host Global Interrupt Clear Register )
USBHS $040C + constant USBHS-HSTIFR ( Host Global Interrupt Set Register )
USBHS $0410 + constant USBHS-HSTIMR ( Host Global Interrupt Mask Register )
USBHS $0414 + constant USBHS-HSTIDR ( Host Global Interrupt Disable Register )
USBHS $0418 + constant USBHS-HSTIER ( Host Global Interrupt Enable Register )
USBHS $0041C + constant USBHS-HSTPIP ( Host Pipe Register )
USBHS $0420 + constant USBHS-HSTFNUM ( Host Frame Number Register )
USBHS $0424 + constant USBHS-HSTADDR1 ( Host Address 1 Register )
USBHS $0428 + constant USBHS-HSTADDR2 ( Host Address 2 Register )
USBHS $042C + constant USBHS-HSTADDR3 ( Host Address 3 Register )
USBHS $500 + constant USBHS-HSTPIPCFG-BASE ( Host Pipe Configuration Register n )
USBHS $530 + constant USBHS-HSTPIPISR-BASE ( Host Pipe Status Register n )
USBHS $560 + constant USBHS-HSTPIPICR-BASE ( Host Pipe Clear Register n )
USBHS $590 + constant USBHS-HSTPIPIFR-BASE ( Host Pipe Set Register n )
USBHS $5C0 + constant USBHS-HSTPIPIMR-BASE ( Host Pipe Mask Register n )
USBHS $5F0 + constant USBHS-HSTPIPIER-BASE ( Host Pipe Enable Register n )
USBHS $620 + constant USBHS-HSTPIPIDR-BASE ( Host Pipe Disable Register n )
USBHS $650 + constant USBHS-HSTPIPINRQ-BASE ( Host Pipe IN Request Register n )
USBHS $680 + constant USBHS-HSTPIPERR-BASE ( Host Pipe Error Register n )
USBHS $0800 + constant USBHS-CTRL ( General Control Register )
USBHS $0804 + constant USBHS-SR ( General Status Register )
USBHS $0808 + constant USBHS-SCR ( General Status Clear Register )
USBHS $080C + constant USBHS-SFR ( General Status Set Register )
: USBHS-DEVCTRL. ." USBHS-DEVCTRL () $" USBHS-DEVCTRL @ hex. USBHS-DEVCTRL 1b. ;
: USBHS-DEVISR. ." USBHS-DEVISR (read-only) $" USBHS-DEVISR @ hex. USBHS-DEVISR 1b. ;
: USBHS-DEVICR. ." USBHS-DEVICR (write-only) $" USBHS-DEVICR @ hex. USBHS-DEVICR 1b. ;
: USBHS-DEVIFR. ." USBHS-DEVIFR (write-only) $" USBHS-DEVIFR @ hex. USBHS-DEVIFR 1b. ;
: USBHS-DEVIMR. ." USBHS-DEVIMR (read-only) $" USBHS-DEVIMR @ hex. USBHS-DEVIMR 1b. ;
: USBHS-DEVIDR. ." USBHS-DEVIDR (write-only) $" USBHS-DEVIDR @ hex. USBHS-DEVIDR 1b. ;
: USBHS-DEVIER. ." USBHS-DEVIER (write-only) $" USBHS-DEVIER @ hex. USBHS-DEVIER 1b. ;
: USBHS-DEVEPT. ." USBHS-DEVEPT () $" USBHS-DEVEPT @ hex. USBHS-DEVEPT 1b. ;
: USBHS-DEVFNUM. ." USBHS-DEVFNUM (read-only) $" USBHS-DEVFNUM @ hex. USBHS-DEVFNUM 1b. ;
: USBHS-DEVEPTCFGx. ( x -- ) dup ." USBHS-DEVEPTCFG" . ." () $"           $4 * USBHS-DEVEPTCFG-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTISRx. ( x -- ) dup ." USBHS-DEVEPTISR" . ." (read-only) $"  $4 * USBHS-DEVEPTISR-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTICRx. ( x -- ) dup ." USBHS-DEVEPTICR" . ." (write-only) $" $4 * USBHS-DEVEPTICR-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTIFRx. ( x -- ) dup ." USBHS-DEVEPTIFR" . ." (write-only) $" $4 * USBHS-DEVEPTIFR-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTIMRx. ( x -- ) dup ." USBHS-DEVEPTIMR" . ." (read-only) $"  $4 * USBHS-DEVEPTIMR-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTIERx. ( x -- ) dup ." USBHS-DEVEPTIER" . ." (write-only) $" $4 * USBHS-DEVEPTIER-BASE + dup @ hex. 1b. ;
: USBHS-DEVEPTIDRx. ( x -- ) dup ." USBHS-DEVEPTIDR" . ." (write-only) $" $4 * USBHS-DEVEPTIDR-BASE + dup @ hex. 1b. ;
: USBHS-HSTCTRL. ." USBHS-HSTCTRL () $" USBHS-HSTCTRL @ hex. USBHS-HSTCTRL 1b. ;
: USBHS-HSTISR. ." USBHS-HSTISR (read-only) $" USBHS-HSTISR @ hex. USBHS-HSTISR 1b. ;
: USBHS-HSTICR. ." USBHS-HSTICR (write-only) $" USBHS-HSTICR @ hex. USBHS-HSTICR 1b. ;
: USBHS-HSTIFR. ." USBHS-HSTIFR (write-only) $" USBHS-HSTIFR @ hex. USBHS-HSTIFR 1b. ;
: USBHS-HSTIMR. ." USBHS-HSTIMR (read-only) $" USBHS-HSTIMR @ hex. USBHS-HSTIMR 1b. ;
: USBHS-HSTIDR. ." USBHS-HSTIDR (write-only) $" USBHS-HSTIDR @ hex. USBHS-HSTIDR 1b. ;
: USBHS-HSTIER. ." USBHS-HSTIER (write-only) $" USBHS-HSTIER @ hex. USBHS-HSTIER 1b. ;
: USBHS-HSTPIP. ." USBHS-HSTPIP () $" USBHS-HSTPIP @ hex. USBHS-HSTPIP 1b. ;
: USBHS-HSTFNUM. ." USBHS-HSTFNUM () $" USBHS-HSTFNUM @ hex. USBHS-HSTFNUM 1b. ;
: USBHS-HSTADDR1. ." USBHS-HSTADDR1 () $" USBHS-HSTADDR1 @ hex. USBHS-HSTADDR1 1b. ;
: USBHS-HSTADDR2. ." USBHS-HSTADDR2 () $" USBHS-HSTADDR2 @ hex. USBHS-HSTADDR2 1b. ;
: USBHS-HSTADDR3. ." USBHS-HSTADDR3 () $" USBHS-HSTADDR3 @ hex. USBHS-HSTADDR3 1b. ;
: USBHS-HSTPIPCFGx.  ( x -- ) dup ." USBHS-HSTPIPCFG"  . ." () $"           $4 * USBHS-HSTPIPCFG-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPISRx.  ( x -- ) dup ." USBHS-HSTPIPISR"  . ." (read-only) $"  $4 * USBHS-HSTPIPISR-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPICRx.  ( x -- ) dup ." USBHS-HSTPIPICR"  . ." (write-only) $" $4 * USBHS-HSTPIPICR-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPIFRx.  ( x -- ) dup ." USBHS-HSTPIPIFR"  . ." (write-only) $" $4 * USBHS-HSTPIPIFR-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPIMRx.  ( x -- ) dup ." USBHS-HSTPIPIMR"  . ." (read-only) $"  $4 * USBHS-HSTPIPIMR-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPIERx.  ( x -- ) dup ." USBHS-HSTPIPIER"  . ." (write-only) $" $4 * USBHS-HSTPIPIER-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPIDRx.  ( x -- ) dup ." USBHS-HSTPIPIDR"  . ." (write-only) $" $4 * USBHS-HSTPIPIDR-BASE  + dup @ hex. 1b. ;
: USBHS-HSTPIPINRQx. ( x -- ) dup ." USBHS-HSTPIPINRQ" . ." () $"           $4 * USBHS-HSTPIPINRQ-BASE + dup @ hex. 1b. ;
: USBHS-HSTPIPERRx.  ( x -- ) dup ." USBHS-HSTPIPERR"  . ." () $"           $4 * USBHS-HSTPIPERR-BASE  + dup @ hex. 1b. ;
: USBHS-CTRL. ." USBHS-CTRL () $" USBHS-CTRL @ hex. USBHS-CTRL 1b. ;
: USBHS-SR. ." USBHS-SR (read-only) $" USBHS-SR @ hex. USBHS-SR 1b. ;
: USBHS-SCR. ." USBHS-SCR (write-only) $" USBHS-SCR @ hex. USBHS-SCR 1b. ;
: USBHS-SFR. ." USBHS-SFR (write-only) $" USBHS-SFR @ hex. USBHS-SFR 1b. ;
: USBHS.
USBHS-DEVCTRL.
USBHS-DEVISR.
USBHS-DEVICR.
USBHS-DEVIFR.
USBHS-DEVIMR.
USBHS-DEVIDR.
USBHS-DEVIER.
USBHS-DEVEPT.
USBHS-DEVFNUM.
0 USBHS-DEVEPTCFGx.
0 USBHS-DEVEPTISRx.
0 USBHS-DEVEPTICRx.
0 USBHS-DEVEPTIFRx.
0 USBHS-DEVEPTIMRx.
0 USBHS-DEVEPTIERx.
0 USBHS-DEVEPTIDRx.
USBHS-HSTCTRL.
USBHS-HSTISR.
USBHS-HSTICR.
USBHS-HSTIFR.
USBHS-HSTIMR.
USBHS-HSTIDR.
USBHS-HSTIER.
USBHS-HSTPIP.
USBHS-HSTFNUM.
USBHS-HSTADDR1.
USBHS-HSTADDR2.
USBHS-HSTADDR3.
0 USBHS-HSTPIPCFGx.
0 USBHS-HSTPIPISRx.
0 USBHS-HSTPIPICRx.
0 USBHS-HSTPIPIFRx.
0 USBHS-HSTPIPIMRx.
0 USBHS-HSTPIPIERx.
0 USBHS-HSTPIPIDRx.
0 USBHS-HSTPIPINRQx.
0 USBHS-HSTPIPERRx.
USBHS-CTRL.
USBHS-SR.
USBHS-SCR.
USBHS-SFR.
;

$400E0400 constant UTMI ( USB Transmitter Interface Macrocell )
UTMI $10 + constant UTMI-OHCIICR ( OHCI Interrupt Configuration Register )
UTMI $30 + constant UTMI-CKTRIM ( UTMI Clock Trimming Register )
: UTMI-OHCIICR. ." UTMI-OHCIICR () $" UTMI-OHCIICR @ hex. UTMI-OHCIICR 1b. ;
: UTMI-CKTRIM. ." UTMI-CKTRIM () $" UTMI-CKTRIM @ hex. UTMI-CKTRIM 1b. ;
: UTMI.
UTMI-OHCIICR.
UTMI-CKTRIM.
;