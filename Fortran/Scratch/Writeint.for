C     Last change:  AMM  28 Oct 2002   12:56 pm
      SUBROUTINE WRITEINT
      INCLUDE 'TAPESIR.INC'
      INCLUDE 'INTER.INC'
c Changed size of KSTA from 8 to 10 to match INFACEIR/KAN variable (def in INTER.INC)
      CHARACTER*10 KSTA(500)
      Real Q(NIE), poll(4,10)

      CHARACTER*12  filein, filout, station
C
*****************************************************************************
*
      WRITE(*,2000)

C
C     Get input file
C
       WRITE(*,10)
   10  FORMAT( /,2X,'PLEASE TYPE THE NAME OF THE ASCII DATA FILE:  ',\)
       READ(*,15) filein
C
   15  FORMAT(A12)
************************
*
*C     Get input file format
*C
*       WRITE(*,16)
*   16  FORMAT( /,2X,'PLEASE SELECT THE TYPE OF ASCII DATA FILE TO BE ',
*     +  'CONVERTED:',/,6X,
*     + '1.  Standard Interface ASCII File (1):  ',/,6X,
*     + '2.  Exported ACCESS Data Text File (2):  ',\)
*       READ(*,18) ntype
        ntype = 1
   18  FORMAT(I1)
C
      OPEN(1,FILE=filein)
      REWIND(1)
C
C     Get output file name and type:
C
       WRITE(*,25)
   25  FORMAT( //,2X,'PLEASE ENTER THE INTERFACE FILE NAME TO BE',
     +       ' CREATED:  ',\)
       READ(*,15) filout
C
*
           OPEN(2,FILE=filout,FORM='UNFORMATTED')
*
*
******************************************************************************
C      
*     Read & Write the header lines of the interface file for each type:
      IF(ntype.LE.1) THEN
C
        READ(1,*) title(1)
        READ(1,*) title(2)
*
        READ(1,*) idatez, tzero
*
        READ(1,*) title(3)
        READ(1,*) title(4)
*
*
        READ(1,*) source, locats, NQUAL, triba, njce
cc        IF(NJCE.LE.0) READ(1,*) (nloc(K), K=1, locats)
        IF(NJCE.LE.0)then
          READ(1,*) (KSTA(K), K=1, locats)
          do I=1,locats
            CALL CONVERT_CH(KSTA(I),nloc(I) )
            end do
          end if
c
cc        IF(NJCE.GE.1) READ(1,*) (KAN(K), K=1, locats)
        IF(NJCE.GE.1)then
          READ(1,*) (KSTA(K), K=1, locats)
c AMM 10/28/02 Removed character conversion
c          do I=1,locats
c            CALL CONVERT_CH(KSTA(I),nloc(I) )
c            end do
          end if
        IF(NQUAL.GT.0) READ(1,*)  (pname(J),J=1,NQUAL)
        IF(NQUAL.GT.0) READ(1,*)  (punit(J),J=1,NQUAL)
        IF(NQUAL.GT.0) READ(1,*)  (ndim(J),J=1,NQUAL)
        READ(1,*) qconv
        
      ELSE
*          

C     Get first two title lines
C
       WRITE(*,100)
  100  FORMAT( /,2X,'Please enter text for title #1:',\)
       READ(*,110) title(1)
C       
       WRITE(*,105)
  105  FORMAT( /,2X,'Please enter text for title #2:',\)
       READ(*,110) title(2)
  110  FORMAT(A80)
C
       WRITE(*,120)
  120  FORMAT( /,5X,'How many hydrographs should be read from the',
     +        ' file?:  ',\)
       READ(*,122) locats
  122  FORMAT(I2) 
          
          Do 128 K = 1, locats
             WRITE(*,124) K
  124  FORMAT( 10X,'Enter node name/number for hydrograph #',I2,'  ',\)
             READ(*,125) KAN(K)
  125  FORMAT(A10)
  128     CONTINUE
C         
C         Determine if flows are CFS or MGD
       WRITE(*,130)
  130  FORMAT( /,5X,'Please indicate the type of flow units: ',
     +        /,10X,'1.  Cubic feet per second, cfs (1):',
     +        /,10X,'2.  Million gallons per day, MGD (2): ',\)
       READ(*,18) mtype
C
            IF(mtype.LE.1) qconv = 1.0
            IF(mtype.GE.2) qconv = 1.547
            
C         Read the first line of data to get initial date and time:
          READ(1,*) station, nday, month, nyr, nhr, min, nsec, 
     +              (Q(j),j=1,locats)
          REWIND(1)
                 
            idatez = mdate(nday,month,nyr)
            tzero  = nhr*3600 + min*60 + nsec
C          
C         Create last two lines of header:
         title(3) = 'Hydrographs exported from ACCESS database for '
         title(3) = title(3) // 'station ' // station
         title(4) = 'Program SCRATCH, Option #2 developed by CH2M HILL'
         source = 'SCRATCH Opt#2'
         njce = 1
         triba = 0.
         NQUAL = 0
         
      ENDIF
*
          WRITE(2) title(1)
          WRITE(2) title(2)
*
          WRITE(2) idatez, tzero
*
          WRITE(2) title(3)
          WRITE(2) title(4)
*
*
          WRITE(2) source, locats, NQUAL, triba, njce
**          WRITE(2) source, locats, NQUAL, triba
          IF(NJCE.LE.0) WRITE(2) (nloc(K), K=1, locats)
          IF(NQUAL.GT.0) WRITE(2)  (pname(J),J=1,NQUAL)
* AMM 10/28/02 KSTA actually stores the character locations
*          IF(NJCE.GE.1) WRITE(2) (KAN(I),I=1,LOCATS)
          IF(NJCE.GE.1) WRITE(2) (KSTA(I),I=1,LOCATS)
          IF(NQUAL.GT.0) WRITE(2)  (punit(J),J=1,NQUAL)
          IF(NQUAL.GT.0) WRITE(2)  (ndim(J),J=1,NQUAL)
*	Re-set qconv factor to 1.0 and apply original qconv to cfs:
          cvhold = qconv
          qconv = 1.0
          WRITE(2) qconv
*
*
***************************************************************************
*
*	Set up DO WHILE to loop through file and read in each line:
*
C
        DO WHILE(nerr.EQ.0)
* Istep = 1, 540000
C

*	Test if there is any pollutant data to read in, else read in flow data:
*
       IF(NQUAL.GT.0) THEN
*
            READ(1,*,ERR=3000,IOSTAT=nerr)  julday, timday, RDELTA,
     +            (q(k), (poll(J,K),J=1,NQUAL), K=1,locats)
*
*				Reset real delta (RDELTA) to double precision: DELTA
*
                 DELTA = RDELTA
*
             DO 170 K = 1, locats
                Q(K) = Q(K) * cvhold
 170         CONTINUE
*
            WRITE(2) julday, timday, DELTA, (Q(K),
     &               (poll(J,K),J=1,NQUAL), K=1,locats)
*
*
       ELSE 
          IF(ntype.LE.1) THEN
*
              READ(1,*,ERR=3000,IOSTAT=nerr)  julday, timday, RDELTA,
     &                                     (Q(K),K=1,locats)
          ELSE
              READ(1,*,ERR=3000,IOSTAT=nerr) station, nday, month, nyr,
     +        nhr, min, nsec,(Q(j),j=1,locats)
                           
            julday = mdate(nday,month,nyr)
            timday = nhr*3600 + min*60 + nsec
            IF(RDELTA.LE.0.0001) THEN 
                READ(1,*) station, nyr, month, nday, nhr, min, nsec
                tim2 = nhr*3600 + min*60 + nsec
                RDELTA = tim2 - timday
                BACKSPACE(1)
            ENDIF
                 
          ENDIF
*       
*				Reset real delta (RDELTA) to double precision: DELTA
*
                 DELTA = RDELTA
*
*
             DO 200 K = 1, locats
                Q(K) = Q(K) * cvhold
 200         CONTINUE
*
                 WRITE(2) julday, timday, DELTA, 
     &                    (Q(K),K=1,locats)
*
*
      ENDIF
*
C
*
*
 1000  END DO
*
C
C**********************************************************************
C         The following is the read error statement.
C**********************************************************************
C
 3000  IF((nerr.EQ.-1).OR.(nerr.EQ.6505).OR.(nerr.EQ.0))THEN
C
C**********************************************************************
C         An expected end of error, the program has successfully 
C         finished the transformation.
C**********************************************************************
C
          WRITE(*,3110)
      ELSE
C
C**********************************************************************
C         Unexpected error occurred, write message plus the error number 
C**********************************************************************

          WRITE(*,3120) nerr
      ENDIF
C
C**********************************************************************
*
2000  FORMAT( /,' >>>>  CREATE STANDARD SWMM INTERFACE FILES (JIN):',
     + //)
C
 3110  FORMAT(/,5x,'>>>  File Transformation Complete  <<<',)
C
 3120  FORMAT(//,5x,'==>> UNKNOWN ERROR OCCURRED:  Error # ',I4,/)
C
*
C
       CLOSE(1)
       CLOSE(2)
C
C
       STOP
       END
