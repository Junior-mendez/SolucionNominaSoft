‹
`D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaAplicacion\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str )
)) *
]* +
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str +
)+ ,
], -
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *…8
kD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaAplicacion\Servicios\ProcesarContratoServicio.cs
	namespace 	
CapaAplicacion
 
. 
	Servicios "
{ 
public 

class $
ProcesarContratoServicio )
{ 
private 
	GestorSQL 
gestorAccesoDatos +
;+ ,
private 
ContratoDAO 
contratoDAO '
;' (
private 
EmpleadoDAO 
empleadoDAO '
;' (
private 
AfpDAO 
afpDAO 
; 
public $
ProcesarContratoServicio '
(' (
)( )
{ 	
gestorAccesoDatos 
= 
new  #
	GestorSQL$ -
(- .
). /
;/ 0
afpDAO 
= 
new 
AfpDAO 
(  
gestorAccesoDatos  1
)1 2
;2 3
contratoDAO 
= 
new 
ContratoDAO )
() *
gestorAccesoDatos* ;
,; <
empleadoDAO< G
,G H
afpDAOI O
)O P
;P Q
empleadoDAO 
= 
new 
EmpleadoDAO )
() *
gestorAccesoDatos* ;
); <
;< =
} 	
public   
Empleado   
buscarEmpleado   &
(  & '
String  ' -
Dni  . 1
)  1 2
{!! 	
gestorAccesoDatos"" 
."" 
abrirConexion"" ,
("", -
)""- .
;"". /
Empleado## 
empleado## 
=## 
empleadoDAO##  +
.##+ ,
buscarPorDni##, 8
(##8 9
Dni##9 <
)##< =
;##= >
gestorAccesoDatos$$ 
.$$ 
cerrarConexion$$ ,
($$, -
)$$- .
;$$. /
return%% 
empleado%% 
;%% 
}'' 	
public)) 
Boolean)) '
buscarUltimoContratoVigente)) 2
())2 3
String))3 9
Dni)): =
)))= >
{** 	
try,, 
{-- 
gestorAccesoDatos.. !
...! "
abrirConexion.." /
(../ 0
)..0 1
;..1 2
Contrato// 
contrato// !
=//" #
contratoDAO//$ /
./// 0 
buscarUltimoContrato//0 D
(//D E
Dni//E H
)//H I
;//I J
gestorAccesoDatos00 !
.00! "
cerrarConexion00" 0
(000 1
)001 2
;002 3
if11 
(11 
contrato11 
.11 %
ValidarVigenciaDeContrato11 6
(116 7
)117 8
)118 9
{22 
return33 
true33 
;33  
}44 
else55 
{66 
return77 
false77  
;77  !
}88 
}99 
catch:: 
(:: 
	Exception:: 
):: 
{;; 
return<< 
false<< 
;<< 
}== 
}>> 	
public@@ 
Contrato@@  
buscarUltimoContrato@@ ,
(@@, -
String@@- 3
Dni@@4 7
)@@7 8
{AA 	
gestorAccesoDatosBB 
.BB 
abrirConexionBB +
(BB+ ,
)BB, -
;BB- .
ContratoCC 
contratoCC 
=CC 
contratoDAOCC  +
.CC+ , 
buscarUltimoContratoCC, @
(CC@ A
DniCCA D
)CCD E
;CCE F
gestorAccesoDatosDD 
.DD 
cerrarConexionDD ,
(DD, -
)DD- .
;DD. /
returnFF 
contratoFF 
;FF 
}GG 	
publicJJ 
BooleanJJ 
guardarContratoJJ &
(JJ& '
ContratoJJ' /
contratoJJ0 8
,JJ8 9
EmpleadoJJ: B
empleadoJJC K
,JJK L
AfpJJM P
afpJJQ T
)JJT U
{KK 	
RegistroDeContratoLL 
registroDeContratoLL 1
=LL2 3
newLL4 7
RegistroDeContratoLL8 J
(LLJ K
)LLK L
;LLL M
tryNN 
{NN 
ifOO 
(OO 
registroDeContratoOO &
.OO& '
validarContratoOO' 6
(OO6 7
contratoOO7 ?
,OO? @
empleadoOOA I
,OOI J
afpOOK N
)OON O
)OOO P
{PP 
gestorAccesoDatosRR %
.RR% &
abrirConexionRR& 3
(RR3 4
)RR4 5
;RR5 6
contratoDAOSS 
.SS  
crearContratoSS  -
(SS- .
contratoSS. 6
,SS6 7
empleadoSS8 @
,SS@ A
afpSSB E
)SSE F
;SSF G
gestorAccesoDatosTT %
.TT% &
cerrarConexionTT& 4
(TT4 5
)TT5 6
;TT6 7
returnUU 
trueUU 
;UU  
}VV 
}WW 
catchXX 
(XX 
	ExceptionXX 
)XX 
{YY 
throwZZ 
newZZ 
	ExceptionZZ #
(ZZ# $
$strZZ$ 7
)ZZ7 8
;ZZ8 9
}[[ 
return\\ 
false\\ 
;\\ 
}]] 	
public__ 
void__ 
editarContrato__ "
(__" #
Contrato__# +
contrato__, 4
)__4 5
{`` 	
gestorAccesoDatosaa 
.aa 
abrirConexionaa +
(aa+ ,
)aa, -
;aa- .
contratoDAObb 
.bb 
editarContratobb &
(bb& '
contratobb( 0
)bb0 1
;bb1 2
gestorAccesoDatoscc 
.cc 
cerrarConexioncc ,
(cc, -
)cc- .
;cc. /
}ee 	
publicgg 
voidgg 
anularContratogg "
(gg" #
Contratogg# +
contratogg, 4
)gg4 5
{hh 	
gestorAccesoDatosii 
.ii 
abrirConexionii +
(ii+ ,
)ii, -
;ii- .
contratoDAOjj 
.jj 
anularContratojj &
(jj& '
contratojj' /
)jj/ 0
;jj0 1
gestorAccesoDatoskk 
.kk 
cerrarConexionkk ,
(kk, -
)kk- .
;kk. /
}mm 	
publicnn 
Afpnn 
	buscarAfpnn 
(nn 
stringnn #
nombrenn$ *
)nn* +
{oo 	
gestorAccesoDatospp 
.pp 
abrirConexionpp +
(pp+ ,
)pp, -
;pp- .
Afpqq 
afpqq 
=qq 
afpDAOqq 
.qq 
buscarPorCodigoqq ,
(qq, -
nombreqq- 3
)qq3 4
;qq4 5
gestorAccesoDatosrr 
.rr 
cerrarConexionrr ,
(rr, -
)rr- .
;rr. /
returntt 
afptt 
;tt 
}uu 	
}vv 
}ww ‰A
gD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaAplicacion\Servicios\ProcesarPagoServicio.cs
	namespace 	
CapaAplicacion
 
. 
	Servicios "
{ 
public 

class  
ProcesarPagoServicio %
{ 
private 
IGestorAccesoADatos #
gestorAccesoDatos$ 5
;5 6
private 
	IContrato 
contratoDAO %
;% &
private 
IBoleta 
	boletaDAO !
;! "
private 
	IConcepto 
conceptoDAO %
;% &
private 
IPeriodo 
periodoDePagoDAO )
;) *
private 
	IEmpleado 
empleadoDAO %
;% &
private 
IAfp 
afpDAO 
; 
public  
ProcesarPagoServicio #
(# $
)$ %
{ 	
FabricaAbstracta   
fabricaAbstracta   -
=  . /
FabricaAbstracta  0 @
.  @ A
crearInstancia  A O
(  O P
)  P Q
;  Q R
gestorAccesoDatos"" 
="" 
fabricaAbstracta""  0
.""0 1"
crearGestorAccesoDatos""1 G
(""G H
)""H I
;""I J
contratoDAO$$ 
=$$ 
fabricaAbstracta$$ *
.$$* +
crearContrato$$+ 8
($$8 9
gestorAccesoDatos$$9 J
,$$J K
empleadoDAO$$K V
,$$V W
afpDAO$$W ]
)$$] ^
;$$^ _
	boletaDAO%% 
=%% 
fabricaAbstracta%% (
.%%( )
crearBoleta%%) 4
(%%4 5
gestorAccesoDatos%%5 F
)%%F G
;%%G H
conceptoDAO'' 
='' 
fabricaAbstracta'' *
.''* +
crearConcepto''+ 8
(''8 9
gestorAccesoDatos''9 J
,''J K
periodoDePagoDAO''L \
,''\ ]
contratoDAO''] h
)''h i
;''i j
periodoDePagoDAO)) 
=)) 
fabricaAbstracta)) /
.))/ 0
crearPeriodo))0 <
())< =
gestorAccesoDatos))= N
)))N O
;))O P
}++ 	
private-- 
List-- 
<-- 
Contrato-- 
>-- "
buscarContratosActivos-- 5
(--5 6
PeriodoDePago--6 C
periodo--D K
)--K L
{.. 	
gestorAccesoDatos// 
.// 
abrirConexion// +
(//+ ,
)//, -
;//- .
List00 
<00 
Contrato00 
>00 
	contratos00 $
=00% &
contratoDAO00' 2
.002 3
listarContrato003 A
(00A B
$str00B E
,00E F
periodo00F M
.00M N
FechaInicio00N Y
,00Y Z
periodo00Z a
.00a b
FechaFin00b j
)00j k
;00k l
gestorAccesoDatos11 
.11 
cerrarConexion11 ,
(11, -
)11- .
;11. /
return22 
	contratos22 
;22 
}33 	
private66 
BoletaDePago66 
generarBoleta66 *
(66* +
Contrato66+ 3
contrato664 <
,66< =&
ConceptoDeIngresoDescuento66> X
concepto66Y a
,66a b
PeriodoDePago66c p
periodo66q x
)66x y
{77 	
RegistroDePago88 
registroDePago88 )
=88* +
new88, /
RegistroDePago880 >
(88> ?
)88? @
;88@ A
BoletaDePago99 
boleta99 
=99  !
new99" %
BoletaDePago99& 2
(992 3
contrato993 ;
,99; <
periodo99= D
,99D E
concepto99E M
)99M N
;99N O
boleta;; 
=;; 
registroDePago;; #
.;;# $
registrarPago;;$ 1
(;;1 2
contrato;;2 :
,;;: ;
periodo;;< C
,;;C D
concepto;;D L
);;L M
;;;M N
boleta<< 
.<< 
Contrato<< 
=<< 
contrato<< &
;<<& '
boleta== 
.== &
ConceptoDeIngresoDescuento== -
===. /
concepto==0 8
;==8 9
return>> 
boleta>> 
;>> 
}?? 	
publicAA 
ListAA 
<AA 
BoletaDePagoAA  
>AA  !
generarBoletasAA" 0
(AA0 1
PeriodoDePagoAA1 >
periodoDePagoAA? L
)AAL M
{BB 	
ListCC 
<CC 
ContratoCC 
>CC 
contratosVigentesCC ,
=CC- ."
buscarContratosActivosCC/ E
(CCE F
periodoDePagoCCF S
)CCS T
;CCT U
ListDD 
<DD 
BoletaDePagoDD 
>DD 
listaDeBoletasDD -
=DD. /
newDD0 3
ListDD4 8
<DD8 9
BoletaDePagoDD9 E
>DDE F
(DDF G
)DDG H
;DDH I&
ConceptoDeIngresoDescuentoEE &
conceptoEE' /
=EE0 1
newEE2 5&
ConceptoDeIngresoDescuentoEE6 P
(EEP Q
periodoDePagoEEQ ^
)EE^ _
;EE_ `
BoletaDePagoFF 
boletaFF 
=FF  !
newFF" %
BoletaDePagoFF& 2
(FF2 3
)FF3 4
;FF4 5
gestorAccesoDatosGG 
.GG 
abrirConexionGG +
(GG+ ,
)GG, -
;GG- .
foreachHH 
(HH 
ContratoHH 
contratoVigenteHH -
inHH. 0
contratosVigentesHH1 B
)HHB C
{II 
conceptoJJ 
=JJ 
conceptoDAOJJ &
.JJ& '
buscarConceptoJJ' 5
(JJ5 6
contratoVigenteJJ6 E
,JJE F
periodoDePagoJJG T
)JJT U
;JJU V
boletaKK 
=KK 
generarBoletaKK &
(KK& '
contratoVigenteKK' 6
,KK6 7
conceptoKK8 @
,KK@ A
periodoDePagoKKB O
)KKO P
;KKP Q
	boletaDAOLL 
.LL 
guardarBoletaLL '
(LL' (
boletaLL( .
)LL. /
;LL/ 0
listaDeBoletasMM 
.MM 
AddMM "
(MM" #
boletaMM# )
)MM) *
;MM* +
}NN 
periodoDePagoDAOOO 
.OO 
actualizarPeriodoOO .
(OO. /
periodoDePagoOO/ <
)OO< =
;OO= >
gestorAccesoDatosPP 
.PP 
cerrarConexionPP ,
(PP, -
)PP- .
;PP. /
returnQQ 
listaDeBoletasQQ !
;QQ! "
}RR 	
publicTT 
PeriodoDePagoTT 
buscarPeriodoTT *
(TT* +
DateTimeTT+ 3
fechaInicioTT4 ?
,TT? @
DateTimeTTA I
fechaFinTTJ R
)TTR S
{UU 	
gestorAccesoDatosVV 
.VV 
abrirConexionVV +
(VV+ ,
)VV, -
;VV- .
PeriodoDePagoWW 
periodoWW !
=WW" #
periodoDePagoDAOWW$ 4
.WW4 5
buscarPeriodoFechaWW5 G
(WWG H
fechaInicioWWH S
,WWS T
fechaFinWWU ]
)WW] ^
;WW^ _
gestorAccesoDatosXX 
.XX 
cerrarConexionXX ,
(XX, -
)XX- .
;XX. /
returnYY 
periodoYY 
;YY 
}[[ 	
public\\ 
PeriodoDePago\\ 
buscarPeriodoActivo\\ 0
(\\0 1
Boolean\\1 8
estado\\9 ?
)\\? @
{]] 	
gestorAccesoDatos^^ 
.^^ 
abrirConexion^^ +
(^^+ ,
)^^, -
;^^- .
PeriodoDePago__ 
periodo__ !
=__" #
periodoDePagoDAO__$ 4
.__4 5
buscarPeriodoActivo__5 H
(__H I
estado__I O
)__O P
;__P Q
gestorAccesoDatos`` 
.`` 
cerrarConexion`` ,
(``, -
)``- .
;``. /
returnaa 
periodoaa 
;aa 
}cc 	
}hh 
}ii 