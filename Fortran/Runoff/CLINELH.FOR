      SUBROUTINE CLINEL
C=======================================================================
      INCLUDE 'CLNAME.INC'
      CHARACTER*1 FIRSTCH
      CHARACTER*50 FNAME1
      CHARACTER*1  FNAME2(50)
      CHARACTER*80 CMDLN1
      CHARACTER*1  CMDLN2(80)
      CHARACTER*1  BLANK
      INTEGER*4 I,IFIL,POS,FPOS
      EQUIVALENCE (CMDLN1,CMDLN2)
      EQUIVALENCE (FNAME1,FNAME2)
C
      BLANK=' '
      FPOS=1
      POS=1
      NNAMES=0
      FNAME1=BLANK
C
      CALL GETCL(CMDLN1)
      IF (CMDLN2(1).EQ.BLANK) RETURN
C
  100 CONTINUE
      IF (CMDLN2(POS) .NE. BLANK) THEN
         FNAME2(FPOS)=CMDLN2(POS)
         IF (POS .EQ. 80) THEN
            NNAMES=NNAMES+1
            CNAMES(NNAMES) = FNAME1
            FNAME1=BLANK
            GOTO 300
         ENDIF
         POS =POS +1
         FPOS=FPOS+1
         GOTO 100
      ENDIF
C
      NNAMES=NNAMES+1
      CNAMES(NNAMES) = FNAME1
      FNAME1=BLANK
      FPOS=1
C
  200 POS=POS+1
      IF (CMDLN2(POS) .EQ. BLANK .AND. POS .LT. 80) GOTO 200
      IF (CMDLN2(POS) .EQ. BLANK .AND. POS .EQ. 80) GOTO 300
      GO TO 100
C
  300 CONTINUE
      RETURN
      END
