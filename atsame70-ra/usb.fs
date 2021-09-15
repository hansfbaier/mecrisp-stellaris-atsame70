: +nWords ( n addr -- 4*n+addr )
    swap ( addr n*4 )
    +         ( addr+n*4 )
;

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
USBHS $100 + constant USBHS-DEVEPTCFGx ( Device Endpoint Configuration Register n )
USBHS $130 + constant USBHS-DEVEPTISRx ( Device Endpoint Status Register n )
USBHS $160 + constant USBHS-DEVEPTICRx ( Device Endpoint Clear Register n )
USBHS $190 + constant USBHS-DEVEPTIFRx ( Device Endpoint Set Register n )
USBHS $1C0 + constant USBHS-DEVEPTIMRx ( Device Endpoint Mask Register n )
USBHS $1F0 + constant USBHS-DEVEPTIERx ( Device Endpoint Enable Register n )
USBHS $220 + constant USBHS-DEVEPTIDRx ( Device Endpoint Disable Register n )
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
USBHS $500 + constant USBHS-HSTPIPCFGx ( Host Pipe Configuration Register n )
USBHS $530 + constant USBHS-HSTPIPISRx ( Host Pipe Status Register n )
USBHS $560 + constant USBHS-HSTPIPICRx ( Host Pipe Clear Register n )
USBHS $590 + constant USBHS-HSTPIPIFRx ( Host Pipe Set Register n )
USBHS $5C0 + constant USBHS-HSTPIPIMRx ( Host Pipe Mask Register n )
USBHS $5F0 + constant USBHS-HSTPIPIERx ( Host Pipe Enable Register n )
USBHS $620 + constant USBHS-HSTPIPIDRx ( Host Pipe Disable Register n )
USBHS $650 + constant USBHS-HSTPIPINRQx ( Host Pipe IN Request Register n )
USBHS $680 + constant USBHS-HSTPIPERRx ( Host Pipe Error Register n )
USBHS $0800 + constant USBHS-CTRL ( General Control Register )
USBHS $0804 + constant USBHS-SR ( General Status Register )
USBHS $0808 + constant USBHS-SCR ( General Status Clear Register )
USBHS $080C + constant USBHS-SFR ( General Status Set Register )
: USBHS-DEVCTRL. ." USBHS-DEVCTRL () $"          USBHS-DEVCTRL @ hex. USBHS-DEVCTRL 1b. ;
: USBHS-DEVISR. ." USBHS-DEVISR (read-only) $"   USBHS-DEVISR  @ hex. USBHS-DEVISR 1b. ;
: USBHS-DEVICR. ." USBHS-DEVICR (write-only) $"  USBHS-DEVICR  @ hex. USBHS-DEVICR 1b. ;
: USBHS-DEVIFR. ." USBHS-DEVIFR (write-only) $"  USBHS-DEVIFR  @ hex. USBHS-DEVIFR 1b. ;
: USBHS-DEVIMR. ." USBHS-DEVIMR (read-only) $"   USBHS-DEVIMR  @ hex. USBHS-DEVIMR 1b. ;
: USBHS-DEVIDR. ." USBHS-DEVIDR (write-only) $"  USBHS-DEVIDR  @ hex. USBHS-DEVIDR 1b. ;
: USBHS-DEVIER. ." USBHS-DEVIER (write-only) $"  USBHS-DEVIER  @ hex. USBHS-DEVIER 1b. ;
: USBHS-DEVEPT. ." USBHS-DEVEPT () $"            USBHS-DEVEPT  @ hex. USBHS-DEVEPT 1b. ;
: USBHS-DEVFNUM. ." USBHS-DEVFNUM (read-only) $" USBHS-DEVFNUM @ hex. USBHS-DEVFNUM 1b. ;
: USBHS-DEVEPTCFGx. ( x -- ) dup ." USBHS-DEVEPTCFG" . ." () $"           USBHS-DEVEPTCFGx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTISRx. ( x -- ) dup ." USBHS-DEVEPTISR" . ." (read-only) $"  USBHS-DEVEPTISRx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTICRx. ( x -- ) dup ." USBHS-DEVEPTICR" . ." (write-only) $" USBHS-DEVEPTICRx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTIFRx. ( x -- ) dup ." USBHS-DEVEPTIFR" . ." (write-only) $" USBHS-DEVEPTIFRx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTIMRx. ( x -- ) dup ." USBHS-DEVEPTIMR" . ." (read-only) $"  USBHS-DEVEPTIMRx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTIERx. ( x -- ) dup ." USBHS-DEVEPTIER" . ." (write-only) $" USBHS-DEVEPTIERx +nWords dup @ hex. 1b. ;
: USBHS-DEVEPTIDRx. ( x -- ) dup ." USBHS-DEVEPTIDR" . ." (write-only) $" USBHS-DEVEPTIDRx +nWords dup @ hex. 1b. ;
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
: USBHS-HSTPIPCFGx.  ( x -- ) dup ." USBHS-HSTPIPCFG"  . ." () $"           USBHS-HSTPIPCFGx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPISRx.  ( x -- ) dup ." USBHS-HSTPIPISR"  . ." (read-only) $"  USBHS-HSTPIPISRx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPICRx.  ( x -- ) dup ." USBHS-HSTPIPICR"  . ." (write-only) $" USBHS-HSTPIPICRx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPIFRx.  ( x -- ) dup ." USBHS-HSTPIPIFR"  . ." (write-only) $" USBHS-HSTPIPIFRx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPIMRx.  ( x -- ) dup ." USBHS-HSTPIPIMR"  . ." (read-only) $"  USBHS-HSTPIPIMRx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPIERx.  ( x -- ) dup ." USBHS-HSTPIPIER"  . ." (write-only) $" USBHS-HSTPIPIERx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPIDRx.  ( x -- ) dup ." USBHS-HSTPIPIDR"  . ." (write-only) $" USBHS-HSTPIPIDRx  +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPINRQx. ( x -- ) dup ." USBHS-HSTPIPINRQ" . ." () $"           USBHS-HSTPIPINRQx +nWords dup @ hex. 1b. ;
: USBHS-HSTPIPERRx.  ( x -- ) dup ." USBHS-HSTPIPERR"  . ." () $"           USBHS-HSTPIPERRx  +nWords dup @ hex. 1b. ;
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

\ USBHS-DEVCTRL ()
: USBHS-DEVCTRL_UADD   ( %XXXXXXX -- ) 0 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_UADD    USB Address
: USBHS-DEVCTRL_ADDEN   %1 7 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_ADDEN    Address Enable
: USBHS-DEVCTRL_DETACH   %1 8 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_DETACH    Detach
: USBHS-DEVCTRL_RMWKUP   %1 9 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_RMWKUP    Remote Wake-Up
: USBHS-DEVCTRL_SPDCONF   ( %XX -- ) 10 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_SPDCONF    Mode Configuration
: USBHS-DEVCTRL_LS   %1 12 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_LS    Low-Speed Mode Force
: USBHS-DEVCTRL_TSTJ   %1 13 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_TSTJ    Test mode J
: USBHS-DEVCTRL_TSTK   %1 14 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_TSTK    Test mode K
: USBHS-DEVCTRL_TSTPCKT   %1 15 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_TSTPCKT    Test packet mode
: USBHS-DEVCTRL_OPMODE2   %1 16 lshift USBHS-DEVCTRL bis! ;  \ USBHS-DEVCTRL_OPMODE2    Specific Operational mode

\ USBHS-DEVISR (read-only)
: USBHS-DEVISR_SUSP   %1 0 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_SUSP    Suspend Interrupt
: USBHS-DEVISR_MSOF   %1 1 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_MSOF    Micro Start of Frame Interrupt
: USBHS-DEVISR_SOF   %1 2 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_SOF    Start of Frame Interrupt
: USBHS-DEVISR_EORST   %1 3 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_EORST    End of Reset Interrupt
: USBHS-DEVISR_WAKEUP   %1 4 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_WAKEUP    Wake-Up Interrupt
: USBHS-DEVISR_EORSM   %1 5 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_EORSM    End of Resume Interrupt
: USBHS-DEVISR_UPRSM   %1 6 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_UPRSM    Upstream Resume Interrupt
: USBHS-DEVISR_PEP_0   %1 12 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_0    Endpoint 0 Interrupt
: USBHS-DEVISR_PEP_1   %1 13 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_1    Endpoint 1 Interrupt
: USBHS-DEVISR_PEP_2   %1 14 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_2    Endpoint 2 Interrupt
: USBHS-DEVISR_PEP_3   %1 15 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_3    Endpoint 3 Interrupt
: USBHS-DEVISR_PEP_4   %1 16 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_4    Endpoint 4 Interrupt
: USBHS-DEVISR_PEP_5   %1 17 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_5    Endpoint 5 Interrupt
: USBHS-DEVISR_PEP_6   %1 18 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_6    Endpoint 6 Interrupt
: USBHS-DEVISR_PEP_7   %1 19 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_7    Endpoint 7 Interrupt
: USBHS-DEVISR_PEP_8   %1 20 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_8    Endpoint 8 Interrupt
: USBHS-DEVISR_PEP_9   %1 21 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_9    Endpoint 9 Interrupt
: USBHS-DEVISR_PEP_10   %1 22 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_10    Endpoint 10 Interrupt
: USBHS-DEVISR_PEP_11   %1 23 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_PEP_11    Endpoint 11 Interrupt
: USBHS-DEVISR_DMA_1   %1 25 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_1    DMA Channel 1 Interrupt
: USBHS-DEVISR_DMA_2   %1 26 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_2    DMA Channel 2 Interrupt
: USBHS-DEVISR_DMA_3   %1 27 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_3    DMA Channel 3 Interrupt
: USBHS-DEVISR_DMA_4   %1 28 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_4    DMA Channel 4 Interrupt
: USBHS-DEVISR_DMA_5   %1 29 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_5    DMA Channel 5 Interrupt
: USBHS-DEVISR_DMA_6   %1 30 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_6    DMA Channel 6 Interrupt
: USBHS-DEVISR_DMA_7   %1 31 lshift USBHS-DEVISR bis! ;  \ USBHS-DEVISR_DMA_7    DMA Channel 7 Interrupt

\ USBHS-DEVICR (write-only)
: USBHS-DEVICR_SUSPC   %1 0 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_SUSPC    Suspend Interrupt Clear
: USBHS-DEVICR_MSOFC   %1 1 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_MSOFC    Micro Start of Frame Interrupt Clear
: USBHS-DEVICR_SOFC   %1 2 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_SOFC    Start of Frame Interrupt Clear
: USBHS-DEVICR_EORSTC   %1 3 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_EORSTC    End of Reset Interrupt Clear
: USBHS-DEVICR_WAKEUPC   %1 4 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_WAKEUPC    Wake-Up Interrupt Clear
: USBHS-DEVICR_EORSMC   %1 5 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_EORSMC    End of Resume Interrupt Clear
: USBHS-DEVICR_UPRSMC   %1 6 lshift USBHS-DEVICR bis! ;  \ USBHS-DEVICR_UPRSMC    Upstream Resume Interrupt Clear

\ USBHS-DEVIFR (write-only)
: USBHS-DEVIFR_SUSPS   %1 0 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_SUSPS    Suspend Interrupt Set
: USBHS-DEVIFR_MSOFS   %1 1 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_MSOFS    Micro Start of Frame Interrupt Set
: USBHS-DEVIFR_SOFS   %1 2 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_SOFS    Start of Frame Interrupt Set
: USBHS-DEVIFR_EORSTS   %1 3 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_EORSTS    End of Reset Interrupt Set
: USBHS-DEVIFR_WAKEUPS   %1 4 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_WAKEUPS    Wake-Up Interrupt Set
: USBHS-DEVIFR_EORSMS   %1 5 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_EORSMS    End of Resume Interrupt Set
: USBHS-DEVIFR_UPRSMS   %1 6 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_UPRSMS    Upstream Resume Interrupt Set
: USBHS-DEVIFR_DMA_1   %1 25 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_1    DMA Channel 1 Interrupt Set
: USBHS-DEVIFR_DMA_2   %1 26 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_2    DMA Channel 2 Interrupt Set
: USBHS-DEVIFR_DMA_3   %1 27 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_3    DMA Channel 3 Interrupt Set
: USBHS-DEVIFR_DMA_4   %1 28 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_4    DMA Channel 4 Interrupt Set
: USBHS-DEVIFR_DMA_5   %1 29 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_5    DMA Channel 5 Interrupt Set
: USBHS-DEVIFR_DMA_6   %1 30 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_6    DMA Channel 6 Interrupt Set
: USBHS-DEVIFR_DMA_7   %1 31 lshift USBHS-DEVIFR bis! ;  \ USBHS-DEVIFR_DMA_7    DMA Channel 7 Interrupt Set

\ USBHS-DEVIMR (read-only)
: USBHS-DEVIMR_SUSPE   %1 0 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_SUSPE    Suspend Interrupt Mask
: USBHS-DEVIMR_MSOFE   %1 1 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_MSOFE    Micro Start of Frame Interrupt Mask
: USBHS-DEVIMR_SOFE   %1 2 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_SOFE    Start of Frame Interrupt Mask
: USBHS-DEVIMR_EORSTE   %1 3 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_EORSTE    End of Reset Interrupt Mask
: USBHS-DEVIMR_WAKEUPE   %1 4 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_WAKEUPE    Wake-Up Interrupt Mask
: USBHS-DEVIMR_EORSME   %1 5 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_EORSME    End of Resume Interrupt Mask
: USBHS-DEVIMR_UPRSME   %1 6 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_UPRSME    Upstream Resume Interrupt Mask
: USBHS-DEVIMR_PEP_0   %1 12 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_0    Endpoint 0 Interrupt Mask
: USBHS-DEVIMR_PEP_1   %1 13 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_1    Endpoint 1 Interrupt Mask
: USBHS-DEVIMR_PEP_2   %1 14 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_2    Endpoint 2 Interrupt Mask
: USBHS-DEVIMR_PEP_3   %1 15 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_3    Endpoint 3 Interrupt Mask
: USBHS-DEVIMR_PEP_4   %1 16 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_4    Endpoint 4 Interrupt Mask
: USBHS-DEVIMR_PEP_5   %1 17 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_5    Endpoint 5 Interrupt Mask
: USBHS-DEVIMR_PEP_6   %1 18 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_6    Endpoint 6 Interrupt Mask
: USBHS-DEVIMR_PEP_7   %1 19 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_7    Endpoint 7 Interrupt Mask
: USBHS-DEVIMR_PEP_8   %1 20 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_8    Endpoint 8 Interrupt Mask
: USBHS-DEVIMR_PEP_9   %1 21 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_9    Endpoint 9 Interrupt Mask
: USBHS-DEVIMR_PEP_10   %1 22 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_10    Endpoint 10 Interrupt Mask
: USBHS-DEVIMR_PEP_11   %1 23 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_PEP_11    Endpoint 11 Interrupt Mask
: USBHS-DEVIMR_DMA_1   %1 25 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_1    DMA Channel 1 Interrupt Mask
: USBHS-DEVIMR_DMA_2   %1 26 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_2    DMA Channel 2 Interrupt Mask
: USBHS-DEVIMR_DMA_3   %1 27 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_3    DMA Channel 3 Interrupt Mask
: USBHS-DEVIMR_DMA_4   %1 28 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_4    DMA Channel 4 Interrupt Mask
: USBHS-DEVIMR_DMA_5   %1 29 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_5    DMA Channel 5 Interrupt Mask
: USBHS-DEVIMR_DMA_6   %1 30 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_6    DMA Channel 6 Interrupt Mask
: USBHS-DEVIMR_DMA_7   %1 31 lshift USBHS-DEVIMR bis! ;  \ USBHS-DEVIMR_DMA_7    DMA Channel 7 Interrupt Mask

\ USBHS-DEVIDR (write-only)
: USBHS-DEVIDR_SUSPEC   %1 0 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_SUSPEC    Suspend Interrupt Disable
: USBHS-DEVIDR_MSOFEC   %1 1 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_MSOFEC    Micro Start of Frame Interrupt Disable
: USBHS-DEVIDR_SOFEC   %1 2 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_SOFEC    Start of Frame Interrupt Disable
: USBHS-DEVIDR_EORSTEC   %1 3 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_EORSTEC    End of Reset Interrupt Disable
: USBHS-DEVIDR_WAKEUPEC   %1 4 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_WAKEUPEC    Wake-Up Interrupt Disable
: USBHS-DEVIDR_EORSMEC   %1 5 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_EORSMEC    End of Resume Interrupt Disable
: USBHS-DEVIDR_UPRSMEC   %1 6 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_UPRSMEC    Upstream Resume Interrupt Disable
: USBHS-DEVIDR_PEP_0   %1 12 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_0    Endpoint 0 Interrupt Disable
: USBHS-DEVIDR_PEP_1   %1 13 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_1    Endpoint 1 Interrupt Disable
: USBHS-DEVIDR_PEP_2   %1 14 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_2    Endpoint 2 Interrupt Disable
: USBHS-DEVIDR_PEP_3   %1 15 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_3    Endpoint 3 Interrupt Disable
: USBHS-DEVIDR_PEP_4   %1 16 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_4    Endpoint 4 Interrupt Disable
: USBHS-DEVIDR_PEP_5   %1 17 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_5    Endpoint 5 Interrupt Disable
: USBHS-DEVIDR_PEP_6   %1 18 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_6    Endpoint 6 Interrupt Disable
: USBHS-DEVIDR_PEP_7   %1 19 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_7    Endpoint 7 Interrupt Disable
: USBHS-DEVIDR_PEP_8   %1 20 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_8    Endpoint 8 Interrupt Disable
: USBHS-DEVIDR_PEP_9   %1 21 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_9    Endpoint 9 Interrupt Disable
: USBHS-DEVIDR_PEP_10   %1 22 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_10    Endpoint 10 Interrupt Disable
: USBHS-DEVIDR_PEP_11   %1 23 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_PEP_11    Endpoint 11 Interrupt Disable
: USBHS-DEVIDR_DMA_1   %1 25 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_1    DMA Channel 1 Interrupt Disable
: USBHS-DEVIDR_DMA_2   %1 26 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_2    DMA Channel 2 Interrupt Disable
: USBHS-DEVIDR_DMA_3   %1 27 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_3    DMA Channel 3 Interrupt Disable
: USBHS-DEVIDR_DMA_4   %1 28 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_4    DMA Channel 4 Interrupt Disable
: USBHS-DEVIDR_DMA_5   %1 29 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_5    DMA Channel 5 Interrupt Disable
: USBHS-DEVIDR_DMA_6   %1 30 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_6    DMA Channel 6 Interrupt Disable
: USBHS-DEVIDR_DMA_7   %1 31 lshift USBHS-DEVIDR bis! ;  \ USBHS-DEVIDR_DMA_7    DMA Channel 7 Interrupt Disable

\ USBHS-DEVIER (write-only)
: USBHS-DEVIER_SUSPES   %1 0 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_SUSPES    Suspend Interrupt Enable
: USBHS-DEVIER_MSOFES   %1 1 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_MSOFES    Micro Start of Frame Interrupt Enable
: USBHS-DEVIER_SOFES   %1 2 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_SOFES    Start of Frame Interrupt Enable
: USBHS-DEVIER_EORSTES   %1 3 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_EORSTES    End of Reset Interrupt Enable
: USBHS-DEVIER_WAKEUPES   %1 4 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_WAKEUPES    Wake-Up Interrupt Enable
: USBHS-DEVIER_EORSMES   %1 5 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_EORSMES    End of Resume Interrupt Enable
: USBHS-DEVIER_UPRSMES   %1 6 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_UPRSMES    Upstream Resume Interrupt Enable
: USBHS-DEVIER_PEP_0   %1 12 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_0    Endpoint 0 Interrupt Enable
: USBHS-DEVIER_PEP_1   %1 13 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_1    Endpoint 1 Interrupt Enable
: USBHS-DEVIER_PEP_2   %1 14 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_2    Endpoint 2 Interrupt Enable
: USBHS-DEVIER_PEP_3   %1 15 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_3    Endpoint 3 Interrupt Enable
: USBHS-DEVIER_PEP_4   %1 16 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_4    Endpoint 4 Interrupt Enable
: USBHS-DEVIER_PEP_5   %1 17 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_5    Endpoint 5 Interrupt Enable
: USBHS-DEVIER_PEP_6   %1 18 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_6    Endpoint 6 Interrupt Enable
: USBHS-DEVIER_PEP_7   %1 19 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_7    Endpoint 7 Interrupt Enable
: USBHS-DEVIER_PEP_8   %1 20 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_8    Endpoint 8 Interrupt Enable
: USBHS-DEVIER_PEP_9   %1 21 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_9    Endpoint 9 Interrupt Enable
: USBHS-DEVIER_PEP_10   %1 22 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_10    Endpoint 10 Interrupt Enable
: USBHS-DEVIER_PEP_11   %1 23 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_PEP_11    Endpoint 11 Interrupt Enable
: USBHS-DEVIER_DMA_1   %1 25 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_1    DMA Channel 1 Interrupt Enable
: USBHS-DEVIER_DMA_2   %1 26 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_2    DMA Channel 2 Interrupt Enable
: USBHS-DEVIER_DMA_3   %1 27 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_3    DMA Channel 3 Interrupt Enable
: USBHS-DEVIER_DMA_4   %1 28 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_4    DMA Channel 4 Interrupt Enable
: USBHS-DEVIER_DMA_5   %1 29 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_5    DMA Channel 5 Interrupt Enable
: USBHS-DEVIER_DMA_6   %1 30 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_6    DMA Channel 6 Interrupt Enable
: USBHS-DEVIER_DMA_7   %1 31 lshift USBHS-DEVIER bis! ;  \ USBHS-DEVIER_DMA_7    DMA Channel 7 Interrupt Enable

\ USBHS-DEVEPT ()
: USBHS-DEVEPT_EPEN0   %1 0 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN0    Endpoint 0 Enable
: USBHS-DEVEPT_EPEN1   %1 1 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN1    Endpoint 1 Enable
: USBHS-DEVEPT_EPEN2   %1 2 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN2    Endpoint 2 Enable
: USBHS-DEVEPT_EPEN3   %1 3 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN3    Endpoint 3 Enable
: USBHS-DEVEPT_EPEN4   %1 4 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN4    Endpoint 4 Enable
: USBHS-DEVEPT_EPEN5   %1 5 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN5    Endpoint 5 Enable
: USBHS-DEVEPT_EPEN6   %1 6 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN6    Endpoint 6 Enable
: USBHS-DEVEPT_EPEN7   %1 7 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN7    Endpoint 7 Enable
: USBHS-DEVEPT_EPEN8   %1 8 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN8    Endpoint 8 Enable
: USBHS-DEVEPT_EPEN9   %1 9 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPEN9    Endpoint 9 Enable
: USBHS-DEVEPT_EPRST0   %1 16 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST0    Endpoint 0 Reset
: USBHS-DEVEPT_EPRST1   %1 17 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST1    Endpoint 1 Reset
: USBHS-DEVEPT_EPRST2   %1 18 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST2    Endpoint 2 Reset
: USBHS-DEVEPT_EPRST3   %1 19 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST3    Endpoint 3 Reset
: USBHS-DEVEPT_EPRST4   %1 20 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST4    Endpoint 4 Reset
: USBHS-DEVEPT_EPRST5   %1 21 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST5    Endpoint 5 Reset
: USBHS-DEVEPT_EPRST6   %1 22 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST6    Endpoint 6 Reset
: USBHS-DEVEPT_EPRST7   %1 23 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST7    Endpoint 7 Reset
: USBHS-DEVEPT_EPRST8   %1 24 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST8    Endpoint 8 Reset
: USBHS-DEVEPT_EPRST9   %1 25 lshift USBHS-DEVEPT bis! ;  \ USBHS-DEVEPT_EPRST9    Endpoint 9 Reset

\ USBHS-DEVFNUM (read-only)
: USBHS-DEVFNUM_MFNUM   ( %XXX -- ) 0 lshift USBHS-DEVFNUM bis! ;  \ USBHS-DEVFNUM_MFNUM    Micro Frame Number
: USBHS-DEVFNUM_FNUM  3 lshift USBHS-DEVFNUM bis! ;                \ USBHS-DEVFNUM_FNUM     Frame Number
: USBHS-DEVFNUM_FNCERR   %1 15 lshift USBHS-DEVFNUM bis! ;         \ USBHS-DEVFNUM_FNCERR   Frame Number CRC Error

\ USBHS-DEVEPTCFGx ()
: USBHS-DEVEPTCFGx_ALLOC   ( x -- )   %1 1 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;       \ USBHS-DEVEPTCFGx_ALLOC    Endpoint Memory Allocate
: USBHS-DEVEPTCFGx_EPBK    ( %XX x -- )  swap 2 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;  \ USBHS-DEVEPTCFGx_EPBK     Endpoint Banks
: USBHS-DEVEPTCFGx_EPSIZE  ( %XXX x -- ) swap 4 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;  \ USBHS-DEVEPTCFGx_EPSIZE   Endpoint Size
: USBHS-DEVEPTCFGx_EPDIR   ( x -- )   %1 8 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;       \ USBHS-DEVEPTCFGx_EPDIR    Endpoint Direction
: USBHS-DEVEPTCFGx_AUTOSW  ( x -- )   %1 9 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;       \ USBHS-DEVEPTCFGx_AUTOSW   Automatic Switch
: USBHS-DEVEPTCFGx_EPTYPE  ( %XX x -- ) swap 11 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;  \ USBHS-DEVEPTCFGx_EPTYPE   Endpoint Type
: USBHS-DEVEPTCFGx_NBTRANS ( %XX x -- ) swap 13 lshift swap USBHS-DEVEPTCFGx +nWords bis! ;  \ USBHS-DEVEPTCFGx_NBTRANS  Number of transactions per microframe for isochronous endpoint

\ USBHS-DEVEPTISRx (read-only)
: USBHS-DEVEPTISRx_TXINI       ( x -- ) %1 0 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_TXINI    Transmitted IN Data Interrupt
: USBHS-DEVEPTISRx_RXOUTI      ( x -- ) %1 1 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_RXOUTI    Received OUT Data Interrupt
: USBHS-DEVEPTISRx_RXSTPI      ( x -- ) %1 2 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_RXSTPI    Received SETUP Interrupt
: USBHS-DEVEPTISRx_NAKOUTI     ( x -- ) %1 3 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_NAKOUTI    NAKed OUT Interrupt
: USBHS-DEVEPTISRx_NAKINI      ( x -- ) %1 4 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_NAKINI    NAKed IN Interrupt
: USBHS-DEVEPTISRx_OVERFI      ( x -- ) %1 5 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_OVERFI    Overflow Interrupt
: USBHS-DEVEPTISRx_STALLEDI    ( x -- ) %1 6 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_STALLEDI    STALLed Interrupt
: USBHS-DEVEPTISRx_SHORTPACKET ( x -- ) %1 7 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_SHORTPACKET    Short Packet Interrupt
: USBHS-DEVEPTISRx_DTSEQ       ( %XX x -- ) swap 8  lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_DTSEQ    Data Toggle Sequence
: USBHS-DEVEPTISRx_NBUSYBK     ( %XX x -- ) swap 12 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_NBUSYBK    Number of Busy Banks
: USBHS-DEVEPTISRx_CURRBK      ( %XX x -- ) swap 14 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_CURRBK    Current Bank
: USBHS-DEVEPTISRx_RWALL       ( x -- ) %1 16 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_RWALL    Read/Write Allowed
: USBHS-DEVEPTISRx_CTRLDIR     ( x -- ) %1 17 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_CTRLDIR    Control Direction
: USBHS-DEVEPTISRx_CFGOK       ( x -- ) %1 18 lshift swap USBHS-DEVEPTISRx +nWords bis! ;  \ USBHS-DEVEPTISRx_CFGOK    Configuration OK Status

\ USBHS-DEVEPTICRx (write-only)
: USBHS-DEVEPTICRx_TXINIC       ( x -- )  %1 0 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_TXINIC    Transmitted IN Data Interrupt Clear
: USBHS-DEVEPTICRx_RXOUTIC      ( x -- )  %1 1 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_RXOUTIC    Received OUT Data Interrupt Clear
: USBHS-DEVEPTICRx_RXSTPIC      ( x -- )  %1 2 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_RXSTPIC    Received SETUP Interrupt Clear
: USBHS-DEVEPTICRx_NAKOUTIC     ( x -- )  %1 3 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_NAKOUTIC    NAKed OUT Interrupt Clear
: USBHS-DEVEPTICRx_NAKINIC      ( x -- )  %1 4 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_NAKINIC    NAKed IN Interrupt Clear
: USBHS-DEVEPTICRx_OVERFIC      ( x -- )  %1 5 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_OVERFIC    Overflow Interrupt Clear
: USBHS-DEVEPTICRx_STALLEDIC    ( x -- )  %1 6 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_STALLEDIC    STALLed Interrupt Clear
: USBHS-DEVEPTICRx_SHORTPACKETC ( x -- )  %1 7 lshift swap USBHS-DEVEPTICRx +nWords bis! ;  \ USBHS-DEVEPTICRx_SHORTPACKETC    Short Packet Interrupt Clear

\ USBHS-DEVEPTIFRx (write-only)
: USBHS-DEVEPTIFRx_TXINIS        ( x -- ) %1  0 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_TXINIS    Transmitted IN Data Interrupt Set
: USBHS-DEVEPTIFRx_RXOUTIS       ( x -- ) %1  1 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_RXOUTIS    Received OUT Data Interrupt Set
: USBHS-DEVEPTIFRx_RXSTPIS       ( x -- ) %1  2 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_RXSTPIS    Received SETUP Interrupt Set
: USBHS-DEVEPTIFRx_NAKOUTIS      ( x -- ) %1  3 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_NAKOUTIS    NAKed OUT Interrupt Set
: USBHS-DEVEPTIFRx_NAKINIS       ( x -- ) %1  4 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_NAKINIS    NAKed IN Interrupt Set
: USBHS-DEVEPTIFRx_OVERFIS       ( x -- ) %1  5 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_OVERFIS    Overflow Interrupt Set
: USBHS-DEVEPTIFRx_STALLEDIS     ( x -- ) %1  6 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_STALLEDIS    STALLed Interrupt Set
: USBHS-DEVEPTIFRx_SHORTPACKETS  ( x -- ) %1  7 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_SHORTPACKETS    Short Packet Interrupt Set
: USBHS-DEVEPTIFRx_NBUSYBKS      ( x -- ) %1 12 lshift swap USBHS-DEVEPTIFRx +nWords bis! ;  \ USBHS-DEVEPTIFRx_NBUSYBKS    Number of Busy Banks Interrupt Set

\ USBHS-DEVEPTIMRx (read-only)
: USBHS-DEVEPTIMRx_TXINE        ( x -- )  %1  0 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_TXINE    Transmitted IN Data Interrupt
: USBHS-DEVEPTIMRx_RXOUTE       ( x -- )  %1  1 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_RXOUTE    Received OUT Data Interrupt
: USBHS-DEVEPTIMRx_RXSTPE       ( x -- )  %1  2 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_RXSTPE    Received SETUP Interrupt
: USBHS-DEVEPTIMRx_NAKOUTE      ( x -- )  %1  3 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_NAKOUTE    NAKed OUT Interrupt
: USBHS-DEVEPTIMRx_NAKINE       ( x -- )  %1  4 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_NAKINE    NAKed IN Interrupt
: USBHS-DEVEPTIMRx_OVERFE       ( x -- )  %1  5 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_OVERFE    Overflow Interrupt
: USBHS-DEVEPTIMRx_STALLEDE     ( x -- )  %1  6 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_STALLEDE    STALLed Interrupt
: USBHS-DEVEPTIMRx_SHORTPACKETE ( x -- )  %1  7 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_SHORTPACKETE    Short Packet Interrupt
: USBHS-DEVEPTIMRx_NBUSYBKE     ( x -- )  %1 12 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_NBUSYBKE    Number of Busy Banks Interrupt
: USBHS-DEVEPTIMRx_KILLBK       ( x -- )  %1 13 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_KILLBK    Kill IN Bank
: USBHS-DEVEPTIMRx_FIFOCON      ( x -- )  %1 14 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_FIFOCON    FIFO Control
: USBHS-DEVEPTIMRx_EPDISHDMA    ( x -- )  %1 16 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_EPDISHDMA    Endpoint Interrupts Disable HDMA Request
: USBHS-DEVEPTIMRx_NYETDIS      ( x -- )  %1 17 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_NYETDIS    NYET Token Disable
: USBHS-DEVEPTIMRx_RSTDT        ( x -- )  %1 18 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_RSTDT    Reset Data Toggle
: USBHS-DEVEPTIMRx_STALLRQ      ( x -- )  %1 19 lshift swap USBHS-DEVEPTIMRx +nWords bis! ;  \ USBHS-DEVEPTIMRx_STALLRQ    STALL Request

\ USBHS-DEVEPTIERx (write-only)
: USBHS-DEVEPTIERx_TXINES        ( x -- )  %1  0 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_TXINES    Transmitted IN Data Interrupt Enable
: USBHS-DEVEPTIERx_RXOUTES       ( x -- )  %1  1 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_RXOUTES    Received OUT Data Interrupt Enable
: USBHS-DEVEPTIERx_RXSTPES       ( x -- )  %1  2 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_RXSTPES    Received SETUP Interrupt Enable
: USBHS-DEVEPTIERx_NAKOUTES      ( x -- )  %1  3 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_NAKOUTES    NAKed OUT Interrupt Enable
: USBHS-DEVEPTIERx_NAKINES       ( x -- )  %1  4 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_NAKINES    NAKed IN Interrupt Enable
: USBHS-DEVEPTIERx_OVERFES       ( x -- )  %1  5 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_OVERFES    Overflow Interrupt Enable
: USBHS-DEVEPTIERx_STALLEDES     ( x -- )  %1  6 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_STALLEDES    STALLed Interrupt Enable
: USBHS-DEVEPTIERx_SHORTPACKETES ( x -- )  %1  7 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_SHORTPACKETES    Short Packet Interrupt Enable
: USBHS-DEVEPTIERx_NBUSYBKES     ( x -- )  %1 12 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_NBUSYBKES    Number of Busy Banks Interrupt Enable
: USBHS-DEVEPTIERx_KILLBKS       ( x -- )  %1 13 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_KILLBKS    Kill IN Bank
: USBHS-DEVEPTIERx_FIFOCONS      ( x -- )  %1 14 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_FIFOCONS    FIFO Control
: USBHS-DEVEPTIERx_EPDISHDMAS    ( x -- )  %1 16 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_EPDISHDMAS    Endpoint Interrupts Disable HDMA Request Enable
: USBHS-DEVEPTIERx_NYETDISS      ( x -- )  %1 17 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_NYETDISS    NYET Token Disable Enable
: USBHS-DEVEPTIERx_RSTDTS        ( x -- )  %1 18 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_RSTDTS    Reset Data Toggle Enable
: USBHS-DEVEPTIERx_STALLRQS      ( x -- )  %1 19 lshift swap USBHS-DEVEPTIERx +nWords bis! ;  \ USBHS-DEVEPTIERx_STALLRQS    STALL Request Enable

\ USBHS-DEVEPTIDRx (write-only)
: USBHS-DEVEPTIDRx_TXINEC        ( x -- )  %1  0 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_TXINEC         Transmitted IN Interrupt Clear
: USBHS-DEVEPTIDRx_RXOUTEC       ( x -- )  %1  1 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_RXOUTEC        Received OUT Data Interrupt Clear
: USBHS-DEVEPTIDRx_RXSTPEC       ( x -- )  %1  2 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_RXSTPEC        Received SETUP Interrupt Clear
: USBHS-DEVEPTIDRx_NAKOUTEC      ( x -- )  %1  3 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_NAKOUTEC       NAKed OUT Interrupt Clear
: USBHS-DEVEPTIDRx_NAKINEC       ( x -- )  %1  4 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_NAKINEC        NAKed IN Interrupt Clear
: USBHS-DEVEPTIDRx_OVERFEC       ( x -- )  %1  5 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_OVERFEC        Overflow Interrupt Clear
: USBHS-DEVEPTIDRx_STALLEDEC     ( x -- )  %1  6 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_STALLEDEC      STALLed Interrupt Clear
: USBHS-DEVEPTIDRx_SHORTPACKETEC ( x -- )  %1  7 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_SHORTPACKETEC  Shortpacket Interrupt Clear
: USBHS-DEVEPTIDRx_NBUSYBKEC     ( x -- )  %1 12 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_NBUSYBKEC      Number of Busy Banks Interrupt Clear
: USBHS-DEVEPTIDRx_FIFOCONC      ( x -- )  %1 14 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_FIFOCONC       FIFO Control Clear
: USBHS-DEVEPTIDRx_EPDISHDMAC    ( x -- )  %1 16 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_EPDISHDMAC     Endpoint Interrupts Disable HDMA Request Clear
: USBHS-DEVEPTIDRx_NYETDISC      ( x -- )  %1 17 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_NYETDISC       NYET Token Disable Clear
: USBHS-DEVEPTIDRx_STALLRQC      ( x -- )  %1 19 lshift swap USBHS-DEVEPTIDRx +nWords  bis! ;  \ USBHS-DEVEPTIDRx_STALLRQC       STALL Request Clear

\ USBHS-HSTCTRL ()
: USBHS-HSTCTRL_SOFE     %1  8 lshift swap USBHS-HSTCTRL +nWords bis! ;  \ USBHS-HSTCTRL_SOFE    Start of Frame Generation Enable
: USBHS-HSTCTRL_RESET    %1  9 lshift swap USBHS-HSTCTRL +nWords bis! ;  \ USBHS-HSTCTRL_RESET   Send USB Reset
: USBHS-HSTCTRL_RESUME   %1 10 lshift swap USBHS-HSTCTRL +nWords bis! ;  \ USBHS-HSTCTRL_RESUME  Send USB Resume
: USBHS-HSTCTRL_SPDCONF  ( %XX -- ) 12 lshift USBHS-HSTCTRL bis! ;      \ USBHS-HSTCTRL_SPDCONF    Mode Configuration

\ USBHS-HSTISR (read-only)
: USBHS-HSTISR_DCONNI   %1 0 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DCONNI    Device Connection Interrupt
: USBHS-HSTISR_DDISCI   %1 1 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DDISCI    Device Disconnection Interrupt
: USBHS-HSTISR_RSTI   %1 2 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_RSTI    USB Reset Sent Interrupt
: USBHS-HSTISR_RSMEDI   %1 3 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_RSMEDI    Downstream Resume Sent Interrupt
: USBHS-HSTISR_RXRSMI   %1 4 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_RXRSMI    Upstream Resume Received Interrupt
: USBHS-HSTISR_HSOFI   %1 5 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_HSOFI    Host Start of Frame Interrupt
: USBHS-HSTISR_HWUPI   %1 6 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_HWUPI    Host Wake-Up Interrupt
: USBHS-HSTISR_PEP_0   %1 8 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_0    Pipe 0 Interrupt
: USBHS-HSTISR_PEP_1   %1 9 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_1    Pipe 1 Interrupt
: USBHS-HSTISR_PEP_2   %1 10 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_2    Pipe 2 Interrupt
: USBHS-HSTISR_PEP_3   %1 11 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_3    Pipe 3 Interrupt
: USBHS-HSTISR_PEP_4   %1 12 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_4    Pipe 4 Interrupt
: USBHS-HSTISR_PEP_5   %1 13 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_5    Pipe 5 Interrupt
: USBHS-HSTISR_PEP_6   %1 14 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_6    Pipe 6 Interrupt
: USBHS-HSTISR_PEP_7   %1 15 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_7    Pipe 7 Interrupt
: USBHS-HSTISR_PEP_8   %1 16 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_8    Pipe 8 Interrupt
: USBHS-HSTISR_PEP_9   %1 17 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_9    Pipe 9 Interrupt
: USBHS-HSTISR_PEP_10   %1 18 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_10    Pipe 10 Interrupt
: USBHS-HSTISR_PEP_11   %1 19 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_PEP_11    Pipe 11 Interrupt
: USBHS-HSTISR_DMA_1   %1 25 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_1    DMA Channel 1 Interrupt
: USBHS-HSTISR_DMA_2   %1 26 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_2    DMA Channel 2 Interrupt
: USBHS-HSTISR_DMA_3   %1 27 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_3    DMA Channel 3 Interrupt
: USBHS-HSTISR_DMA_4   %1 28 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_4    DMA Channel 4 Interrupt
: USBHS-HSTISR_DMA_5   %1 29 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_5    DMA Channel 5 Interrupt
: USBHS-HSTISR_DMA_6   %1 30 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_6    DMA Channel 6 Interrupt
: USBHS-HSTISR_DMA_7   %1 31 lshift USBHS-HSTISR bis! ;  \ USBHS-HSTISR_DMA_7    DMA Channel 7 Interrupt

\ USBHS-HSTICR (write-only)
: USBHS-HSTICR_DCONNIC   %1 0 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_DCONNIC    Device Connection Interrupt Clear
: USBHS-HSTICR_DDISCIC   %1 1 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_DDISCIC    Device Disconnection Interrupt Clear
: USBHS-HSTICR_RSTIC   %1 2 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_RSTIC    USB Reset Sent Interrupt Clear
: USBHS-HSTICR_RSMEDIC   %1 3 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_RSMEDIC    Downstream Resume Sent Interrupt Clear
: USBHS-HSTICR_RXRSMIC   %1 4 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_RXRSMIC    Upstream Resume Received Interrupt Clear
: USBHS-HSTICR_HSOFIC   %1 5 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_HSOFIC    Host Start of Frame Interrupt Clear
: USBHS-HSTICR_HWUPIC   %1 6 lshift USBHS-HSTICR bis! ;  \ USBHS-HSTICR_HWUPIC    Host Wake-Up Interrupt Clear

\ USBHS-HSTIFR (write-only)
: USBHS-HSTIFR_DCONNIS   %1 0 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DCONNIS    Device Connection Interrupt Set
: USBHS-HSTIFR_DDISCIS   %1 1 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DDISCIS    Device Disconnection Interrupt Set
: USBHS-HSTIFR_RSTIS   %1 2 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_RSTIS    USB Reset Sent Interrupt Set
: USBHS-HSTIFR_RSMEDIS   %1 3 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_RSMEDIS    Downstream Resume Sent Interrupt Set
: USBHS-HSTIFR_RXRSMIS   %1 4 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_RXRSMIS    Upstream Resume Received Interrupt Set
: USBHS-HSTIFR_HSOFIS   %1 5 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_HSOFIS    Host Start of Frame Interrupt Set
: USBHS-HSTIFR_HWUPIS   %1 6 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_HWUPIS    Host Wake-Up Interrupt Set
: USBHS-HSTIFR_DMA_1   %1 25 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_1    DMA Channel 1 Interrupt Set
: USBHS-HSTIFR_DMA_2   %1 26 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_2    DMA Channel 2 Interrupt Set
: USBHS-HSTIFR_DMA_3   %1 27 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_3    DMA Channel 3 Interrupt Set
: USBHS-HSTIFR_DMA_4   %1 28 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_4    DMA Channel 4 Interrupt Set
: USBHS-HSTIFR_DMA_5   %1 29 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_5    DMA Channel 5 Interrupt Set
: USBHS-HSTIFR_DMA_6   %1 30 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_6    DMA Channel 6 Interrupt Set
: USBHS-HSTIFR_DMA_7   %1 31 lshift USBHS-HSTIFR bis! ;  \ USBHS-HSTIFR_DMA_7    DMA Channel 7 Interrupt Set

\ USBHS-HSTIMR (read-only)
: USBHS-HSTIMR_DCONNIE   %1 0 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DCONNIE    Device Connection Interrupt Enable
: USBHS-HSTIMR_DDISCIE   %1 1 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DDISCIE    Device Disconnection Interrupt Enable
: USBHS-HSTIMR_RSTIE   %1 2 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_RSTIE    USB Reset Sent Interrupt Enable
: USBHS-HSTIMR_RSMEDIE   %1 3 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_RSMEDIE    Downstream Resume Sent Interrupt Enable
: USBHS-HSTIMR_RXRSMIE   %1 4 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_RXRSMIE    Upstream Resume Received Interrupt Enable
: USBHS-HSTIMR_HSOFIE   %1 5 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_HSOFIE    Host Start of Frame Interrupt Enable
: USBHS-HSTIMR_HWUPIE   %1 6 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_HWUPIE    Host Wake-Up Interrupt Enable
: USBHS-HSTIMR_PEP_0   %1 8 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_0    Pipe 0 Interrupt Enable
: USBHS-HSTIMR_PEP_1   %1 9 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_1    Pipe 1 Interrupt Enable
: USBHS-HSTIMR_PEP_2   %1 10 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_2    Pipe 2 Interrupt Enable
: USBHS-HSTIMR_PEP_3   %1 11 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_3    Pipe 3 Interrupt Enable
: USBHS-HSTIMR_PEP_4   %1 12 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_4    Pipe 4 Interrupt Enable
: USBHS-HSTIMR_PEP_5   %1 13 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_5    Pipe 5 Interrupt Enable
: USBHS-HSTIMR_PEP_6   %1 14 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_6    Pipe 6 Interrupt Enable
: USBHS-HSTIMR_PEP_7   %1 15 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_7    Pipe 7 Interrupt Enable
: USBHS-HSTIMR_PEP_8   %1 16 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_8    Pipe 8 Interrupt Enable
: USBHS-HSTIMR_PEP_9   %1 17 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_9    Pipe 9 Interrupt Enable
: USBHS-HSTIMR_PEP_10   %1 18 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_10    Pipe 10 Interrupt Enable
: USBHS-HSTIMR_PEP_11   %1 19 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_PEP_11    Pipe 11 Interrupt Enable
: USBHS-HSTIMR_DMA_1   %1 25 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_1    DMA Channel 1 Interrupt Enable
: USBHS-HSTIMR_DMA_2   %1 26 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_2    DMA Channel 2 Interrupt Enable
: USBHS-HSTIMR_DMA_3   %1 27 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_3    DMA Channel 3 Interrupt Enable
: USBHS-HSTIMR_DMA_4   %1 28 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_4    DMA Channel 4 Interrupt Enable
: USBHS-HSTIMR_DMA_5   %1 29 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_5    DMA Channel 5 Interrupt Enable
: USBHS-HSTIMR_DMA_6   %1 30 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_6    DMA Channel 6 Interrupt Enable
: USBHS-HSTIMR_DMA_7   %1 31 lshift USBHS-HSTIMR bis! ;  \ USBHS-HSTIMR_DMA_7    DMA Channel 7 Interrupt Enable

\ USBHS-HSTIDR (write-only)
: USBHS-HSTIDR_DCONNIEC   %1  0 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DCONNIEC   Device Connection Interrupt Disable
: USBHS-HSTIDR_DDISCIEC   %1  1 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DDISCIEC   Device Disconnection Interrupt Disable
: USBHS-HSTIDR_RSTIEC     %1  2 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_RSTIEC     USB Reset Sent Interrupt Disable
: USBHS-HSTIDR_RSMEDIEC   %1  3 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_RSMEDIEC   Downstream Resume Sent Interrupt Disable
: USBHS-HSTIDR_RXRSMIEC   %1  4 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_RXRSMIEC   Upstream Resume Received Interrupt Disable
: USBHS-HSTIDR_HSOFIEC    %1  5 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_HSOFIEC    Host Start of Frame Interrupt Disable
: USBHS-HSTIDR_HWUPIEC    %1  6 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_HWUPIEC    Host Wake-Up Interrupt Disable
: USBHS-HSTIDR_PEP_0      %1  8 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_0      Pipe 0 Interrupt Disable
: USBHS-HSTIDR_PEP_1      %1  9 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_1      Pipe 1 Interrupt Disable
: USBHS-HSTIDR_PEP_2      %1 10 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_2      Pipe 2 Interrupt Disable
: USBHS-HSTIDR_PEP_3      %1 11 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_3      Pipe 3 Interrupt Disable
: USBHS-HSTIDR_PEP_4      %1 12 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_4      Pipe 4 Interrupt Disable
: USBHS-HSTIDR_PEP_5      %1 13 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_5      Pipe 5 Interrupt Disable
: USBHS-HSTIDR_PEP_6      %1 14 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_6      Pipe 6 Interrupt Disable
: USBHS-HSTIDR_PEP_7      %1 15 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_7      Pipe 7 Interrupt Disable
: USBHS-HSTIDR_PEP_8      %1 16 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_8      Pipe 8 Interrupt Disable
: USBHS-HSTIDR_PEP_9      %1 17 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_9      Pipe 9 Interrupt Disable
: USBHS-HSTIDR_PEP_10     %1 18 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_10     Pipe 10 Interrupt Disable
: USBHS-HSTIDR_PEP_11     %1 19 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_PEP_11     Pipe 11 Interrupt Disable
: USBHS-HSTIDR_DMA_1      %1 25 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_1      DMA Channel 1 Interrupt Disable
: USBHS-HSTIDR_DMA_2      %1 26 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_2      DMA Channel 2 Interrupt Disable
: USBHS-HSTIDR_DMA_3      %1 27 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_3      DMA Channel 3 Interrupt Disable
: USBHS-HSTIDR_DMA_4      %1 28 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_4      DMA Channel 4 Interrupt Disable
: USBHS-HSTIDR_DMA_5      %1 29 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_5      DMA Channel 5 Interrupt Disable
: USBHS-HSTIDR_DMA_6      %1 30 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_6      DMA Channel 6 Interrupt Disable
: USBHS-HSTIDR_DMA_7      %1 31 lshift USBHS-HSTIDR bis! ;  \ USBHS-HSTIDR_DMA_7      DMA Channel 7 Interrupt Disable

\ USBHS-HSTIER (write-only)
: USBHS-HSTIER_DCONNIES   %1 0 lshift USBHS-HSTIER bis! ;  \ USBHS-HSTIER_DCONNIES   Device Connection Interrupt Enable
: USBHS-HSTIER_DDISCIES   %1 1 lshift USBHS-HSTIER bis! ;  \ USBHS-HSTIER_DDISCIES   Device Disconnection Interrupt Enable
: USBHS-HSTIER_RSTIES   %1 2 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_RSTIES     USB Reset Sent Interrupt Enable
: USBHS-HSTIER_RSMEDIES   %1 3 lshift USBHS-HSTIER bis! ;  \ USBHS-HSTIER_RSMEDIES   Downstream Resume Sent Interrupt Enable
: USBHS-HSTIER_RXRSMIES   %1 4 lshift USBHS-HSTIER bis! ;  \ USBHS-HSTIER_RXRSMIES   Upstream Resume Received Interrupt Enable
: USBHS-HSTIER_HSOFIES   %1 5 lshift USBHS-HSTIER bis! ;   \ USBHS-HSTIER_HSOFIES    Host Start of Frame Interrupt Enable
: USBHS-HSTIER_HWUPIES   %1 6 lshift USBHS-HSTIER bis! ;   \ USBHS-HSTIER_HWUPIES    Host Wake-Up Interrupt Enable
: USBHS-HSTIER_PEP_0   %1 8 lshift USBHS-HSTIER bis! ;     \ USBHS-HSTIER_PEP_0      Pipe 0 Interrupt Enable
: USBHS-HSTIER_PEP_1   %1 9 lshift USBHS-HSTIER bis! ;     \ USBHS-HSTIER_PEP_1      Pipe 1 Interrupt Enable
: USBHS-HSTIER_PEP_2   %1 10 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_2      Pipe 2 Interrupt Enable
: USBHS-HSTIER_PEP_3   %1 11 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_3      Pipe 3 Interrupt Enable
: USBHS-HSTIER_PEP_4   %1 12 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_4      Pipe 4 Interrupt Enable
: USBHS-HSTIER_PEP_5   %1 13 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_5      Pipe 5 Interrupt Enable
: USBHS-HSTIER_PEP_6   %1 14 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_6      Pipe 6 Interrupt Enable
: USBHS-HSTIER_PEP_7   %1 15 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_7      Pipe 7 Interrupt Enable
: USBHS-HSTIER_PEP_8   %1 16 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_8      Pipe 8 Interrupt Enable
: USBHS-HSTIER_PEP_9   %1 17 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_PEP_9      Pipe 9 Interrupt Enable
: USBHS-HSTIER_PEP_10   %1 18 lshift USBHS-HSTIER bis! ;   \ USBHS-HSTIER_PEP_10     Pipe 10 Interrupt Enable
: USBHS-HSTIER_PEP_11   %1 19 lshift USBHS-HSTIER bis! ;   \ USBHS-HSTIER_PEP_11     Pipe 11 Interrupt Enable
: USBHS-HSTIER_DMA_1   %1 25 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_1      DMA Channel 1 Interrupt Enable
: USBHS-HSTIER_DMA_2   %1 26 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_2      DMA Channel 2 Interrupt Enable
: USBHS-HSTIER_DMA_3   %1 27 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_3      DMA Channel 3 Interrupt Enable
: USBHS-HSTIER_DMA_4   %1 28 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_4      DMA Channel 4 Interrupt Enable
: USBHS-HSTIER_DMA_5   %1 29 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_5      DMA Channel 5 Interrupt Enable
: USBHS-HSTIER_DMA_6   %1 30 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_6      DMA Channel 6 Interrupt Enable
: USBHS-HSTIER_DMA_7   %1 31 lshift USBHS-HSTIER bis! ;    \ USBHS-HSTIER_DMA_7      DMA Channel 7 Interrupt Enable

\ USBHS-HSTPIP ()
: USBHS-HSTPIP_PEN0   %1 0 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN0     Pipe 0 Enable
: USBHS-HSTPIP_PEN1   %1 1 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN1     Pipe 1 Enable
: USBHS-HSTPIP_PEN2   %1 2 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN2     Pipe 2 Enable
: USBHS-HSTPIP_PEN3   %1 3 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN3     Pipe 3 Enable
: USBHS-HSTPIP_PEN4   %1 4 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN4     Pipe 4 Enable
: USBHS-HSTPIP_PEN5   %1 5 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN5     Pipe 5 Enable
: USBHS-HSTPIP_PEN6   %1 6 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN6     Pipe 6 Enable
: USBHS-HSTPIP_PEN7   %1 7 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN7     Pipe 7 Enable
: USBHS-HSTPIP_PEN8   %1 8 lshift USBHS-HSTPIP bis! ;    \ USBHS-HSTPIP_PEN8     Pipe 8 Enable
: USBHS-HSTPIP_PRST0   %1 16 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST0    Pipe 0 Reset
: USBHS-HSTPIP_PRST1   %1 17 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST1    Pipe 1 Reset
: USBHS-HSTPIP_PRST2   %1 18 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST2    Pipe 2 Reset
: USBHS-HSTPIP_PRST3   %1 19 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST3    Pipe 3 Reset
: USBHS-HSTPIP_PRST4   %1 20 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST4    Pipe 4 Reset
: USBHS-HSTPIP_PRST5   %1 21 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST5    Pipe 5 Reset
: USBHS-HSTPIP_PRST6   %1 22 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST6    Pipe 6 Reset
: USBHS-HSTPIP_PRST7   %1 23 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST7    Pipe 7 Reset
: USBHS-HSTPIP_PRST8   %1 24 lshift USBHS-HSTPIP bis! ;  \ USBHS-HSTPIP_PRST8    Pipe 8 Reset

\ USBHS-HSTFNUM ()
: USBHS-HSTFNUM_MFNUM   ( %XXX -- ) 0 lshift USBHS-HSTFNUM bis! ;  \ USBHS-HSTFNUM_MFNUM    Micro Frame Number
: USBHS-HSTFNUM_FNUM  3 lshift USBHS-HSTFNUM bis! ;  \ USBHS-HSTFNUM_FNUM    Frame Number
: USBHS-HSTFNUM_FLENHIGH   ( %XXXXXXXX -- ) 16 lshift USBHS-HSTFNUM bis! ;  \ USBHS-HSTFNUM_FLENHIGH    Frame Length

\ USBHS-HSTADDR1 ()
: USBHS-HSTADDR1_HSTADDRP0   ( %XXXXXXX -- ) 0 lshift USBHS-HSTADDR1 bis! ;  \ USBHS-HSTADDR1_HSTADDRP0    USB Host Address
: USBHS-HSTADDR1_HSTADDRP1   ( %XXXXXXX -- ) 8 lshift USBHS-HSTADDR1 bis! ;  \ USBHS-HSTADDR1_HSTADDRP1    USB Host Address
: USBHS-HSTADDR1_HSTADDRP2   ( %XXXXXXX -- ) 16 lshift USBHS-HSTADDR1 bis! ;  \ USBHS-HSTADDR1_HSTADDRP2    USB Host Address
: USBHS-HSTADDR1_HSTADDRP3   ( %XXXXXXX -- ) 24 lshift USBHS-HSTADDR1 bis! ;  \ USBHS-HSTADDR1_HSTADDRP3    USB Host Address

\ USBHS-HSTADDR2 ()
: USBHS-HSTADDR2_HSTADDRP4   ( %XXXXXXX -- ) 0 lshift USBHS-HSTADDR2 bis! ;  \ USBHS-HSTADDR2_HSTADDRP4    USB Host Address
: USBHS-HSTADDR2_HSTADDRP5   ( %XXXXXXX -- ) 8 lshift USBHS-HSTADDR2 bis! ;  \ USBHS-HSTADDR2_HSTADDRP5    USB Host Address
: USBHS-HSTADDR2_HSTADDRP6   ( %XXXXXXX -- ) 16 lshift USBHS-HSTADDR2 bis! ;  \ USBHS-HSTADDR2_HSTADDRP6    USB Host Address
: USBHS-HSTADDR2_HSTADDRP7   ( %XXXXXXX -- ) 24 lshift USBHS-HSTADDR2 bis! ;  \ USBHS-HSTADDR2_HSTADDRP7    USB Host Address

\ USBHS-HSTADDR3 ()
: USBHS-HSTADDR3_HSTADDRP8   ( %XXXXXXX -- ) 0 lshift USBHS-HSTADDR3 bis! ;  \ USBHS-HSTADDR3_HSTADDRP8    USB Host Address
: USBHS-HSTADDR3_HSTADDRP9   ( %XXXXXXX -- ) 8 lshift USBHS-HSTADDR3 bis! ;  \ USBHS-HSTADDR3_HSTADDRP9    USB Host Address

\ USBHS-HSTPIPCFGx ()
: USBHS-HSTPIPCFGx_ALLOC   ( x -- )              %1 1 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_ALLOC   Pipe Memory Allocate
: USBHS-HSTPIPCFGx_PBK     ( %XX x -- )        swap 2 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_PBK     Pipe Banks
: USBHS-HSTPIPCFGx_PSIZE   ( %XXX x -- )       swap 4 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_PSIZE   Pipe Size
: USBHS-HSTPIPCFGx_PTOKEN  ( %XX x -- )        swap 8 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_PTOKEN  Pipe Token
: USBHS-HSTPIPCFGx_AUTOSW  ( x -- )             %1 10 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_AUTOSW  Automatic Switch
: USBHS-HSTPIPCFGx_PTYPE   ( %XX x -- )       swap 12 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_PTYPE   Pipe Type
: USBHS-HSTPIPCFGx_PEPNUM  ( %XXXX x -- )     swap 16 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_PEPNUM  Pipe Endpoint Number
: USBHS-HSTPIPCFGx_INTFRQ  ( %XXXXXXXX x -- ) swap 24 lshift swap USBHS-HSTPIPCFGx +nWords bis! ;  \ USBHS-HSTPIPCFGx_INTFRQ  Pipe Interrupt Request Frequency

\ USBHS-HSTPIPISRx (read-only)
: USBHS-HSTPIPISRx_RXINI        ( x -- )       %1  0 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_RXINI    Received IN Data Interrupt
: USBHS-HSTPIPISRx_TXOUTI       ( x -- )       %1  1 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_TXOUTI    Transmitted OUT Data Interrupt
: USBHS-HSTPIPISRx_TXSTPI       ( x -- )       %1  2 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_TXSTPI    Transmitted SETUP Interrupt
: USBHS-HSTPIPISRx_PERRI        ( x -- )       %1  3 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_PERRI    Pipe Error Interrupt
: USBHS-HSTPIPISRx_NAKEDI       ( x -- )       %1  4 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_NAKEDI    NAKed Interrupt
: USBHS-HSTPIPISRx_OVERFI       ( x -- )       %1  5 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_OVERFI    Overflow Interrupt
: USBHS-HSTPIPISRx_RXSTALLDI    ( x -- )       %1  6 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_RXSTALLDI    Received STALLed Interrupt
: USBHS-HSTPIPISRx_SHORTPACKETI ( x -- )       %1  7 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_SHORTPACKETI    Short Packet Interrupt
: USBHS-HSTPIPISRx_DTSEQ        ( %XX x -- ) swap  8 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_DTSEQ    Data Toggle Sequence
: USBHS-HSTPIPISRx_NBUSYBK      ( %XX x -- ) swap 12 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_NBUSYBK    Number of Busy Banks
: USBHS-HSTPIPISRx_CURRBK       ( %XX x -- ) swap 14 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_CURRBK    Current Bank
: USBHS-HSTPIPISRx_RWALL        ( x -- )       %1 16 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_RWALL    Read/Write Allowed
: USBHS-HSTPIPISRx_CFGOK        ( x -- )       %1 18 lshift swap USBHS-HSTPIPISRx +nWords bis! ;  \ USBHS-HSTPIPISRx_CFGOK    Configuration OK Status

\ USBHS-HSTPIPICRx (write-only)
: USBHS-HSTPIPICRx_RXINIC        ( x -- ) %1 0 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_RXINIC    Received IN Data Interrupt Clear
: USBHS-HSTPIPICRx_TXOUTIC       ( x -- ) %1 1 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_TXOUTIC    Transmitted OUT Data Interrupt Clear
: USBHS-HSTPIPICRx_TXSTPIC       ( x -- ) %1 2 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_TXSTPIC    Transmitted SETUP Interrupt Clear
: USBHS-HSTPIPICRx_NAKEDIC       ( x -- ) %1 4 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_NAKEDIC    NAKed Interrupt Clear
: USBHS-HSTPIPICRx_OVERFIC       ( x -- ) %1 5 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_OVERFIC    Overflow Interrupt Clear
: USBHS-HSTPIPICRx_RXSTALLDIC    ( x -- ) %1 6 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_RXSTALLDIC    Received STALLed Interrupt Clear
: USBHS-HSTPIPICRx_SHORTPACKETIC ( x -- ) %1 7 lshift swap USBHS-HSTPIPICRx +nWords bis! ;  \ USBHS-HSTPIPICRx_SHORTPACKETIC    Short Packet Interrupt Clear

\ USBHS-HSTPIPIFRx (write-only)
: USBHS-HSTPIPIFRx_RXINIS        ( x -- ) %1  0 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_RXINIS    Received IN Data Interrupt Set
: USBHS-HSTPIPIFRx_TXOUTIS       ( x -- ) %1  1 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_TXOUTIS    Transmitted OUT Data Interrupt Set
: USBHS-HSTPIPIFRx_TXSTPIS       ( x -- ) %1  2 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_TXSTPIS    Transmitted SETUP Interrupt Set
: USBHS-HSTPIPIFRx_PERRIS        ( x -- ) %1  3 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_PERRIS    Pipe Error Interrupt Set
: USBHS-HSTPIPIFRx_NAKEDIS       ( x -- ) %1  4 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_NAKEDIS    NAKed Interrupt Set
: USBHS-HSTPIPIFRx_OVERFIS       ( x -- ) %1  5 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_OVERFIS    Overflow Interrupt Set
: USBHS-HSTPIPIFRx_RXSTALLDIS    ( x -- ) %1  6 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_RXSTALLDIS    Received STALLed Interrupt Set
: USBHS-HSTPIPIFRx_SHORTPACKETIS ( x -- ) %1  7 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_SHORTPACKETIS    Short Packet Interrupt Set
: USBHS-HSTPIPIFRx_NBUSYBKS      ( x -- ) %1 12 lshift swap USBHS-HSTPIPIFRx +nWords bis! ;  \ USBHS-HSTPIPIFRx_NBUSYBKS    Number of Busy Banks Set

\ USBHS-HSTPIPIMRx (read-only)
: USBHS-HSTPIPIMRx_RXINE         ( x -- )  %1  0 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_RXINE    Received IN Data Interrupt Enable
: USBHS-HSTPIPIMRx_TXOUTE        ( x -- )  %1  1 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_TXOUTE    Transmitted OUT Data Interrupt Enable
: USBHS-HSTPIPIMRx_TXSTPE        ( x -- )  %1  2 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_TXSTPE    Transmitted SETUP Interrupt Enable
: USBHS-HSTPIPIMRx_PERRE         ( x -- )  %1  3 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_PERRE    Pipe Error Interrupt Enable
: USBHS-HSTPIPIMRx_NAKEDE        ( x -- )  %1  4 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_NAKEDE    NAKed Interrupt Enable
: USBHS-HSTPIPIMRx_OVERFIE       ( x -- )  %1  5 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_OVERFIE    Overflow Interrupt Enable
: USBHS-HSTPIPIMRx_RXSTALLDE     ( x -- )  %1  6 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_RXSTALLDE    Received STALLed Interrupt Enable
: USBHS-HSTPIPIMRx_SHORTPACKETIE ( x -- )  %1  7 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_SHORTPACKETIE    Short Packet Interrupt Enable
: USBHS-HSTPIPIMRx_NBUSYBKE      ( x -- )  %1 12 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_NBUSYBKE    Number of Busy Banks Interrupt Enable
: USBHS-HSTPIPIMRx_FIFOCON       ( x -- )  %1 14 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_FIFOCON    FIFO Control
: USBHS-HSTPIPIMRx_PDISHDMA      ( x -- )  %1 16 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_PDISHDMA    Pipe Interrupts Disable HDMA Request Enable
: USBHS-HSTPIPIMRx_PFREEZE       ( x -- )  %1 17 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_PFREEZE    Pipe Freeze
: USBHS-HSTPIPIMRx_RSTDT         ( x -- )  %1 18 lshift swap USBHS-HSTPIPIMRx +nWords bis! ;  \ USBHS-HSTPIPIMRx_RSTDT    Reset Data Toggle

\ USBHS-HSTPIPIERx (write-only)
: USBHS-HSTPIPIERx_RXINES         ( x -- ) %1  0 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_RXINES    Received IN Data Interrupt Enable
: USBHS-HSTPIPIERx_TXOUTES        ( x -- ) %1  1 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_TXOUTES    Transmitted OUT Data Interrupt Enable
: USBHS-HSTPIPIERx_TXSTPES        ( x -- ) %1  2 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_TXSTPES    Transmitted SETUP Interrupt Enable
: USBHS-HSTPIPIERx_PERRES         ( x -- ) %1  3 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_PERRES    Pipe Error Interrupt Enable
: USBHS-HSTPIPIERx_NAKEDES        ( x -- ) %1  4 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_NAKEDES    NAKed Interrupt Enable
: USBHS-HSTPIPIERx_OVERFIES       ( x -- ) %1  5 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_OVERFIES    Overflow Interrupt Enable
: USBHS-HSTPIPIERx_RXSTALLDES     ( x -- ) %1  6 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_RXSTALLDES    Received STALLed Interrupt Enable
: USBHS-HSTPIPIERx_SHORTPACKETIES ( x -- ) %1  7 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_SHORTPACKETIES    Short Packet Interrupt Enable
: USBHS-HSTPIPIERx_NBUSYBKES      ( x -- ) %1 12 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_NBUSYBKES    Number of Busy Banks Enable
: USBHS-HSTPIPIERx_PDISHDMAS      ( x -- ) %1 16 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_PDISHDMAS    Pipe Interrupts Disable HDMA Request Enable
: USBHS-HSTPIPIERx_PFREEZES       ( x -- ) %1 17 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_PFREEZES    Pipe Freeze Enable
: USBHS-HSTPIPIERx_RSTDTS         ( x -- ) %1 18 lshift USBHS-HSTPIPIERx bis! ;  \ USBHS-HSTPIPIERx_RSTDTS    Reset Data Toggle Enable

\ USBHS-HSTPIPIDRx (write-only)
: USBHS-HSTPIPIDRx_RXINEC         ( x -- ) %1  0 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_RXINEC    Received IN Data Interrupt Disable
: USBHS-HSTPIPIDRx_TXOUTEC        ( x -- ) %1  1 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_TXOUTEC    Transmitted OUT Data Interrupt Disable
: USBHS-HSTPIPIDRx_TXSTPEC        ( x -- ) %1  2 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_TXSTPEC    Transmitted SETUP Interrupt Disable
: USBHS-HSTPIPIDRx_PERREC         ( x -- ) %1  3 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_PERREC    Pipe Error Interrupt Disable
: USBHS-HSTPIPIDRx_NAKEDEC        ( x -- ) %1  4 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_NAKEDEC    NAKed Interrupt Disable
: USBHS-HSTPIPIDRx_OVERFIEC       ( x -- ) %1  5 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_OVERFIEC    Overflow Interrupt Disable
: USBHS-HSTPIPIDRx_RXSTALLDEC     ( x -- ) %1  6 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_RXSTALLDEC    Received STALLed Interrupt Disable
: USBHS-HSTPIPIDRx_SHORTPACKETIEC ( x -- ) %1  7 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_SHORTPACKETIEC    Short Packet Interrupt Disable
: USBHS-HSTPIPIDRx_NBUSYBKEC      ( x -- ) %1 12 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_NBUSYBKEC    Number of Busy Banks Disable
: USBHS-HSTPIPIDRx_FIFOCONC       ( x -- ) %1 14 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_FIFOCONC    FIFO Control Disable
: USBHS-HSTPIPIDRx_PDISHDMAC      ( x -- ) %1 16 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_PDISHDMAC    Pipe Interrupts Disable HDMA Request Disable
: USBHS-HSTPIPIDRx_PFREEZEC       ( x -- ) %1 17 lshift swap USBHS-HSTPIPIDRx +nWords bis! ;  \ USBHS-HSTPIPIDRx_PFREEZEC    Pipe Freeze Disable

\ USBHS-HSTPIPINRQx ()
: USBHS-HSTPIPINRQx_INRQ   ( %XXXXXXXX x -- ) swap 0 lshift swap USBHS-HSTPIPINRQx +nWords bis! ;  \ USBHS-HSTPIPINRQx_INRQ    IN Request Number before Freeze
: USBHS-HSTPIPINRQx_INMODE ( x -- )             %1 8 lshift swap USBHS-HSTPIPINRQx +nWords bis! ;  \ USBHS-HSTPIPINRQx_INMODE    IN Request Mode

\ USBHS-HSTPIPERRx ()
: USBHS-HSTPIPERRx_DATATGL  ( x -- )       %1 0 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_DATATGL    Data Toggle Error
: USBHS-HSTPIPERRx_DATAPID  ( x -- )       %1 1 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_DATAPID    Data PID Error
: USBHS-HSTPIPERRx_PID      ( x -- )       %1 2 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_PID    Data PID Error
: USBHS-HSTPIPERRx_TIMEOUT  ( x -- )       %1 3 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_TIMEOUT    Time-Out Error
: USBHS-HSTPIPERRx_CRC16    ( x -- )       %1 4 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_CRC16    CRC16 Error
: USBHS-HSTPIPERRx_COUNTER  ( %XX x -- ) swap 5 lshift swap USBHS-HSTPIPERRx +nWords bis! ;  \ USBHS-HSTPIPERRx_COUNTER    Error Counter

\ USBHS-CTRL ()
: USBHS-CTRL_RDERRE   %1 4 lshift USBHS-CTRL bis! ;  \ USBHS-CTRL_RDERRE    Remote Device Connection Error Interrupt Enable
: USBHS-CTRL_VBUSHWC   %1 8 lshift USBHS-CTRL bis! ;  \ USBHS-CTRL_VBUSHWC    VBUS Hardware Control
: USBHS-CTRL_FRZCLK   %1 14 lshift USBHS-CTRL bis! ;  \ USBHS-CTRL_FRZCLK    Freeze USB Clock
: USBHS-CTRL_USBE   %1 15 lshift USBHS-CTRL bis! ;  \ USBHS-CTRL_USBE    USBHS Enable
: USBHS-CTRL_UIMOD   %1 25 lshift USBHS-CTRL bis! ;  \ USBHS-CTRL_UIMOD    USBHS Mode

\ USBHS-SR (read-only)
: USBHS-SR_RDERRI   %1 4 lshift USBHS-SR bis! ;  \ USBHS-SR_RDERRI    Remote Device Connection Error Interrupt Host mode only
: USBHS-SR_SPEED   ( %XX -- ) 12 lshift USBHS-SR bis! ;  \ USBHS-SR_SPEED    Speed Status Device mode only
: USBHS-SR_CLKUSABLE   %1 14 lshift USBHS-SR bis! ;  \ USBHS-SR_CLKUSABLE    UTMI Clock Usable

\ USBHS-SCR (write-only)
: USBHS-SCR_RDERRIC   %1 4 lshift USBHS-SCR bis! ;  \ USBHS-SCR_RDERRIC    Remote Device Connection Error Interrupt Clear

\ USBHS-SFR (write-only)
: USBHS-SFR_RDERRIS   %1 4 lshift USBHS-SFR bis! ;  \ USBHS-SFR_RDERRIS    Remote Device Connection Error Interrupt Set
: USBHS-SFR_VBUSRQS   %1 9 lshift USBHS-SFR bis! ;  \ USBHS-SFR_VBUSRQS    VBUS Request Set

\ UTMI-OHCIICR ()
: UTMI-OHCIICR_RES0   %1 0 lshift UTMI-OHCIICR bis! ;  \ UTMI-OHCIICR_RES0    USB PORTx Reset
: UTMI-OHCIICR_ARIE   %1 4 lshift UTMI-OHCIICR bis! ;  \ UTMI-OHCIICR_ARIE    OHCI Asynchronous Resume Interrupt Enable
: UTMI-OHCIICR_APPSTART   %1 5 lshift UTMI-OHCIICR bis! ;  \ UTMI-OHCIICR_APPSTART
: UTMI-OHCIICR_UDPPUDIS   %1 23 lshift UTMI-OHCIICR bis! ;  \ UTMI-OHCIICR_UDPPUDIS    USB Device Pull-up Disable

\ UTMI-CKTRIM ()
: UTMI-CKTRIM_FREQ   ( %XX -- ) 0 lshift UTMI-CKTRIM bis! ;  \ UTMI-CKTRIM_FREQ    UTMI Reference Clock Frequency
