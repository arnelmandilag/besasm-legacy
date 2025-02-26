      PARAMETER (NQP=NET)
C AMM 5/17/2000 Made GEOM3 Double since read errors were occurring
C               with long IDs (TYPE 22)
      DOUBLE PRECISION XNT, GEOM3
      CHARACTER SCF*4,KINNUM*10,BORDER*10,KYN*10,KPE*10,KJN*10,
     +                                  KUE*10,KOE*10,KGEOM*10

      COMMON/HUGO1/A(NET,2,2),Q(NET,2,2)
      COMMON/HUGO2/CPOL1(NQP,2,4),CPOL2(NQP,2,4)
      COMMON/HUGO3/QFULL(NET),AFULL(NET),DXDT(NET),C1(NET),SLOPE(NET),
     1       DIST(NET),GEOM1(NET),ROUGH(NET),DWDAYS,EPSIL,TIME,DT
      COMMON/HUGO4/QDWF(NET),P1(NET),RNOFF(NET),QINFIL(NET),
     1       WDWF(NET,4),PLUTO(4,NET),P2(NET),P5(NET),P6(NET),P7(NET),
     2       BARREL(NET),GEOM2(NET),QMAX(NET),GEOM3(NET),P4(NET),
     3       SCOUR(NET,4),XNT(50)
      COMMON/HUGO5/KSTORE(NET),NPE(NTH),NYN(NTH),NORDER(NET),JSURF(NTH),
     1       NINNUM(NET),JPLOT(NTH),INUE(0:NET,3),NTYPE(NET),JR(NET),
     2 IOLD(0:NET),NOE(0:NET),NUE(0:NET,3),NNYN,NNPE,NSURF,NPLOT,JPRINT,
     3       NOUTS,INTPRT,NFILTH,NDESN,NCNTRL,NINFIL,KSPG,NINPUT,NKLASS,
     4       NE,NDT,KFULL,NOS,NPOLL,NPRINT,ITER,NITER,M,N
      COMMON/HUGO6/KOE(NET),KUE(NET,3),KYN(NTH),KINNUM(NET),
     1       KPE(NET),KJN(NTH),BORDER(NET),KGEOM(NET),SCF(NET)
