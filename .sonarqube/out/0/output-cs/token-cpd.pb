¢
TD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IAfp.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
IAfp

 
{ 
Afp 
buscarPorCodigo 
( 
string "
nombre# )
)) *
;* +
} 
} ≠
WD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IBoleta.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
IBoleta

 
{ 
void 
guardarBoleta 
( 
BoletaDePago '
boleta( .
). /
;/ 0
} 
} ã
YD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IConcepto.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
	IConcepto

 
{ &
ConceptoDeIngresoDescuento "
buscarConcepto# 1
(1 2
Contrato2 :
contrato; C
,C D
PeriodoDePagoE R
periodoDePagoS `
)` a
;a b
} 
} Í

YD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IContrato.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
	IContrato

 
{ 
List 
< 
Contrato 
> 
listarContrato %
(% &
string& ,
estado- 3
,3 4
DateTime4 <
fechaInicio= H
,H I
DateTimeI Q
fechaFinR Z
)Z [
;[ \
Contrato 
buscarContrato 
(  
int  #
codigo$ *
)* +
;+ ,
void 
crearContrato 
( 
Contrato #
contrato$ ,
,, -
Empleado- 5
empleado6 >
,> ?
Afp@ C
afpD G
)G H
;H I
Contrato  
buscarUltimoContrato %
(% &
string& ,
codigo- 3
)3 4
;4 5
void 
anularContrato 
( 
Contrato $
contrato% -
)- .
;. /
void 
editarContrato 
( 
Contrato $
contrato% -
)- .
;. /
} 
} ´
YD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IEmpleado.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
	IEmpleado

 
{ 
Empleado 
buscarPorDni 
( 
string $
dni% (
)( )
;) *
} 
} ë
cD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IGestorAccesoADatos.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{ 
public		 

	interface		 
IGestorAccesoADatos		 (
{

 
void 
abrirConexion 
( 
) 
; 
void 
cerrarConexion 
( 
) 
; 
void 
iniciarTransaccion 
(  
)  !
;! "
void 
terminarTransaccion  
(  !
)! "
;" #
void 
cancelarTransaccion  
(  !
)! "
;" #
} 
} Æ
XD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Contratos\IPeriodo.cs
	namespace 	
CapaDominio
 
. 
	Contratos 
{		 
public

 

	interface

 
IPeriodo

 
{ 
PeriodoDePago 
buscarPeriodo #
(# $
int$ '
codigoPeriodo( 5
)5 6
;6 7
PeriodoDePago 
buscarPeriodoActivo )
() *
Boolean* 1
estado2 8
)8 9
;9 :
void 
actualizarPeriodo 
( 
PeriodoDePago ,
periodoDePago- :
): ;
;; <
PeriodoDePago 
buscarPeriodoFecha (
(( )
DateTime) 1
fechaInicio2 =
,= >
DateTime? G
fechaFinH P
)P Q
;Q R
} 
} ñ
SD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\Afp.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 
Afp		 
{

 
private 
int 
	codigoAfp 
; 
private 
String 
	nombreAfp  
;  !
private 
float 
porcentajeAfp #
;# $
public 
int 
	CodigoAfp 
{ 
get "
=># %
	codigoAfp& /
;/ 0
set1 4
=>5 7
	codigoAfp8 A
=B C
valueD I
;I J
}K L
public 
string 
	NombreAfp 
{  !
get" %
=>& (
	nombreAfp) 2
;2 3
set4 7
=>8 :
	nombreAfp; D
=E F
valueG L
;L M
}N O
public 
float 
PorcentajeAfp "
{# $
get% (
=>) +
porcentajeAfp, 9
;9 :
set; >
=>? A
porcentajeAfpB O
=P Q
valueR W
;W X
}Y Z
public 
Afp 
( 
) 
{ 	
} 	
} 
} ÖE
\D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\BoletaDePago.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 
BoletaDePago		 
{

 
private 
double 
asignacionFamiliar )
;) *
private 
DateTime 
fechaDeEmision '
;' (
private 
double 
sueldoBasico #
;# $
private 
double 

sueldoNeto !
;! "
private 
double 
totalDeDescuentos (
;( )
private 
double 
totalDeHoras #
;# $
private 
double 
totalDeIngresos &
;& '
private 
double 
descuentoAfp #
;# $
private 
Contrato 
contrato !
;! "
private 
PeriodoDePago 
periodoDePago +
;+ ,
private &
ConceptoDeIngresoDescuento *&
conceptoDeIngresoDescuento+ E
;E F
public 
BoletaDePago 
( 
) 
{ 	
} 	
public 
BoletaDePago 
( 
Contrato $
contrato% -
,- .
PeriodoDePago/ <
periodoDePago= J
)J K
{ 	
this 
. 
contrato 
= 
contrato $
;$ %
this 
. 
PeriodoDePago 
=  
periodoDePago! .
;. /
} 	
public   
BoletaDePago   
(   
Contrato   $
contrato  % -
)  - .
{!! 	
this"" 
."" 
contrato"" 
="" 
contrato"" $
;""$ %
}## 	
public$$ 
BoletaDePago$$ 
($$ 
Contrato$$ $
contrato$$% -
,$$- .&
ConceptoDeIngresoDescuento$$/ I&
conceptoDeIngresoDescuento$$J d
)$$d e
{%% 	
this&& 
.&& 
contrato&& 
=&& 
contrato&& $
;&&$ %
this'' 
.'' &
ConceptoDeIngresoDescuento'' +
='', -&
conceptoDeIngresoDescuento''. H
;''H I
}(( 	
public)) 
BoletaDePago)) 
()) 
Contrato)) $
contrato))% -
,))- .
PeriodoDePago))/ <
periodoDePago))= J
,))J K&
ConceptoDeIngresoDescuento))L f'
conceptoDeIngresoDescuento	))g Å
)
))Å Ç
{** 	
this++ 
.++ 
contrato++ 
=++ 
contrato++ $
;++$ %
this,, 
.,, 
PeriodoDePago,, 
=,,  
periodoDePago,,! .
;,,. /
this-- 
.-- &
ConceptoDeIngresoDescuento-- +
=--, -&
conceptoDeIngresoDescuento--. H
;--H I
}.. 	
public00 
double00 
AsignacionFamiliar00 (
{00) *
get00+ .
=>00/ 1
asignacionFamiliar002 D
;00D E
set00F I
=>00J L
asignacionFamiliar00M _
=00` a
value00b g
;00g h
}00i j
public11 
DateTime11 
FechaDeEmision11 &
{11' (
get11) ,
=>11- /
fechaDeEmision110 >
;11> ?
set11@ C
=>11D F
fechaDeEmision11G U
=11V W
value11X ]
;11] ^
}11_ `
public22 
double22 
SueldoBasico22 "
{22# $
get22% (
=>22) +
sueldoBasico22, 8
;228 9
set22: =
=>22> @
sueldoBasico22A M
=22N O
value22P U
;22U V
}22W X
public33 
double33 

SueldoNeto33  
{33! "
get33# &
=>33' )

sueldoNeto33* 4
;334 5
set336 9
=>33: <

sueldoNeto33= G
=33H I
value33J O
;33O P
}33Q R
public44 
double44 
TotalDeDescuentos44 '
{44( )
get44* -
=>44. 0
totalDeDescuentos441 B
;44B C
set44D G
=>44H J
totalDeDescuentos44K \
=44] ^
value44_ d
;44d e
}44f g
public55 
double55 
TotalDeHoras55 "
{55# $
get55% (
=>55) +
totalDeHoras55, 8
;558 9
set55: =
=>55> @
totalDeHoras55A M
=55N O
value55P U
;55U V
}55W X
public66 
double66 
DescuentoAfp66 "
{66# $
get66% (
=>66) +
descuentoAfp66, 8
;668 9
set66: =
=>66> @
descuentoAfp66A M
=66N O
value66P U
;66U V
}66W X
public77 
double77 
TotalDeIngresos77 %
{77& '
get77( +
=>77, .
totalDeIngresos77/ >
;77> ?
set77@ C
=>77D F
totalDeIngresos77G V
=77W X
value77Y ^
;77^ _
}77` a
public88 
Contrato88 
Contrato88  
{88! "
get88# &
=>88' )
contrato88* 2
;882 3
set884 7
=>888 :
contrato88; C
=88D E
value88F K
;88K L
}88M N
public99 
PeriodoDePago99 
PeriodoDePago99 *
{99+ ,
get99- 0
=>991 3
periodoDePago994 A
;99A B
set99C F
=>99G I
periodoDePago99J W
=99X Y
value99Z _
;99_ `
}99a b
public:: &
ConceptoDeIngresoDescuento:: )&
ConceptoDeIngresoDescuento::* D
{::E F
get::G J
=>::K M&
conceptoDeIngresoDescuento::N h
;::h i
set::j m
=>::n p'
conceptoDeIngresoDescuento	::q ã
=
::å ç
value
::é ì
;
::ì î
}
::ï ñ
public?? 
Double?? !
CalcularDescuentosAfp?? +
(??+ ,
Double??, 2
sueldoBasico??3 ?
,??? @
float??@ E
porcentajeAfp??F S
)??S T
{@@ 	
DoubleAA 
descuentoAFpAA 
;AA  
descuentoAFpBB 
=BB 
sueldoBasicoBB '
*BB( )
(BB* +
porcentajeAfpBB+ 8
)BB8 9
;BB9 :
returnCC 
descuentoAFpCC 
;CC  
}DD 	
publicEE 
doubleEE  
CalcularSueldoBasicoEE *
(EE* +
)EE+ ,
{FF 	
returnGG 
totalDeHorasGG 
*GG  !
ContratoGG" *
.GG* +
PagoPorHoraGG+ 6
;GG8 9
}HH 	
publicKK 
doubleKK 
CalcularSueldoNetoKK (
(KK( )
)KK) *
{LL 	
returnMM 
totalDeIngresosMM "
-MM# $
totalDeDescuentosMM% 6
;MM6 7
}NN 	
publicQQ 
doubleQQ "
CalcularTotalDescuentoQQ ,
(QQ, -
BoletaDePagoQQ- 9
boletaQQ: @
,QQ@ A&
ConceptoDeIngresoDescuentoQQB \
conceptoQQ] e
)QQe f
{RR 	
returnSS 
boletaSS 
.SS 
descuentoAfpSS &
+SS. /
conceptoSS0 8
.SS8 9%
CalcularConceptoDescuentoSS9 R
(SSR S
)SSS T
;SST U
}TT 	
publicWW 
doubleWW  
CalcularTotalDeHorasWW *
(WW* +
)WW+ ,
{XX 	
returnYY 
PeriodoDePagoYY  
.YY  !"
CalcularSemanasPeriodoYY! 7
(YY7 8
)YY8 9
*YY: ;
contratoYY< D
.YYD E
HorasSemanaYYE P
;YYP Q
}ZZ 	
public\\ 
double\\ #
CalcularTotalDeIngresos\\ -
(\\- .&
ConceptoDeIngresoDescuento\\. H
concepto\\I Q
,\\Q R
Contrato\\R Z
contrato\\[ c
)\\c d
{]] 	
return^^ 
sueldoBasico^^ 
+^^  !
contrato^^" *
.^^* +&
CalcularAsignacionFamiliar^^+ E
(^^E F
)^^F G
+^^H I
concepto^^J R
.^^R S#
CalcularConceptoIngreso^^S j
(^^j k
)^^k l
;^^l m
}__ 	
}aa 
}bb ô%
jD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\ConceptoDeIngresoDescuento.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 &
ConceptoDeIngresoDescuento		 +
{

 
private 
int 
codigoConcepto "
;" #
private 
double "
montoDeOtrosDescuentos -
;- .
private 
double  
montoDeOtrosIngresos +
;+ ,
private 
double 
montoPorAdelantos (
;( )
private 
double !
montoPorHorasAusentes ,
;, -
private 
double 
montoPorHorasExtras *
;* +
private 
double 
montoPorReintegros )
;) *
private 
PeriodoDePago 
periodoDePago +
;+ ,
private 
Contrato 
contrato !
;! "
public 
int 
CodigoConcepto !
{" #
get$ '
=>( *
codigoConcepto+ 9
;9 :
set; >
=>? A
codigoConceptoB P
=Q R
valueS X
;X Y
}Z [
public 
double "
MontoDeOtrosDescuentos ,
{- .
get/ 2
=>3 5"
montoDeOtrosDescuentos6 L
;L M
setN Q
=>R T"
montoDeOtrosDescuentosU k
=l m
valuen s
;s t
}u v
public 
double  
MontoDeOtrosIngresos *
{+ ,
get- 0
=>1 3 
montoDeOtrosIngresos4 H
;H I
setJ M
=>N P 
montoDeOtrosIngresosQ e
=f g
valueh m
;m n
}o p
public 
double 
MontoPorAdelantos '
{( )
get* -
=>. 0
montoPorAdelantos1 B
;B C
setD G
=>H J
montoPorAdelantosK \
=] ^
value_ d
;d e
}f g
public 
double !
MontoPorHorasAusentes +
{, -
get. 1
=>2 4!
montoPorHorasAusentes5 J
;J K
setL O
=>P R!
montoPorHorasAusentesS h
=i j
valuek p
;p q
}r s
public 
double 
MontoPorHorasExtras )
{* +
get, /
=>0 2
montoPorHorasExtras3 F
;F G
setH K
=>L N
montoPorHorasExtrasO b
=c d
valuee j
;j k
}l m
public 
double 
MontoPorReintegros (
{) *
get+ .
=>/ 1
montoPorReintegros2 D
;D E
setF I
=>J L
montoPorReintegrosM _
=` a
valueb g
;g h
}i j
public 
PeriodoDePago 
PeriodoDePago *
{+ ,
get- 0
=>1 3
periodoDePago4 A
;A B
setC F
=>G I
periodoDePagoJ W
=X Y
valueZ _
;_ `
}a b
public 
Contrato 
Contrato  
{! "
get# &
=>' )
contrato* 2
;2 3
set4 7
=>8 :
contrato; C
=D E
valueF K
;K L
}M N
public!! &
ConceptoDeIngresoDescuento!! )
(!!) *
)!!* +
{"" 	
}$$ 	
public%% &
ConceptoDeIngresoDescuento%% )
(%%) *
PeriodoDePago%%* 7
periodo%%8 ?
)%%? @
{&& 	
this'' 
.'' 
PeriodoDePago'' 
=''  
periodo''! (
;''( )
}(( 	
public** 
double** #
CalcularConceptoIngreso** -
(**- .
)**. /
{++ 	
return,, 
montoPorHorasExtras,, &
+,,' (
montoPorReintegros,,) ;
+,,< = 
montoDeOtrosIngresos,,> R
;,,R S
}.. 	
public11 
double11 %
CalcularConceptoDescuento11 /
(11/ 0
)110 1
{22 	
return44 !
montoPorHorasAusentes44 (
+44) *
montoPorAdelantos44+ <
+44= >"
montoDeOtrosDescuentos44? U
;44U V
}66 	
}77 
}88 ™;
XD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\Contrato.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 
Contrato		 
{

 
private 
Boolean 
asignacionFamiliar *
;* +
private 
String 
cargo 
; 
private 
int 
codigo 
; 
private 
DateTime 
fechaInicio $
;$ %
private 
DateTime 
fechaFin !
;! "
private 
int 
horasSemana 
;  
private 
double 
pagoPorHora "
;" #
private 
Boolean 
estado 
; 
private 
Empleado 
empleado !
;! "
private 
Afp 
afp 
; 
public 
Contrato 
( 
Afp 
afp 
,  
Empleado! )
empleado* 2
)2 3
{ 	
this 
. 
Afp 
= 
afp 
; 
this 
. 
Empleado 
= 
empleado $
;$ %
} 	
public 
Contrato 
( 
) 
{ 	
} 	
public 
Contrato 
( 
Empleado  
empleado! )
)* +
{ 	
this!! 
.!! 
Empleado!! 
=!! 
empleado!! $
;!!$ %
}"" 	
public## 
Contrato## 
(## 
Afp## 
afp## 
)##  
{$$ 	
this&& 
.&& 
Afp&& 
=&& 
afp&& 
;&& 
}'' 	
public(( 
bool(( 
AsignacionFamiliar(( &
{((' (
get(() ,
=>((- /
asignacionFamiliar((0 B
;((B C
set((D G
=>((H J
asignacionFamiliar((K ]
=((^ _
value((` e
;((e f
}((g h
public)) 
string)) 
Cargo)) 
{)) 
get)) !
=>))" $
cargo))% *
;))* +
set)), /
=>))0 2
cargo))3 8
=))9 :
value)); @
;))@ A
}))B C
public** 
int** 
Codigo** 
{** 
get** 
=>**  "
codigo**# )
;**) *
set**+ .
=>**/ 1
codigo**2 8
=**9 :
value**; @
;**@ A
}**B C
public++ 
DateTime++ 
FechaInicio++ #
{++$ %
get++& )
=>++* ,
fechaInicio++- 8
;++8 9
set++: =
=>++> @
fechaInicio++A L
=++M N
value++O T
;++T U
}++V W
public,, 
DateTime,, 
FechaFin,,  
{,,! "
get,,# &
=>,,' )
fechaFin,,* 2
;,,2 3
set,,4 7
=>,,8 :
fechaFin,,; C
=,,D E
value,,F K
;,,K L
},,M N
public-- 
int-- 
HorasSemana-- 
{--  
get--! $
=>--% '
horasSemana--( 3
;--3 4
set--5 8
=>--9 ;
horasSemana--< G
=--H I
value--J O
;--O P
}--Q R
public.. 
double.. 
PagoPorHora.. !
{.." #
get..$ '
=>..( *
pagoPorHora..+ 6
;..6 7
set..8 ;
=>..< >
pagoPorHora..? J
=..K L
value..M R
;..R S
}..T U
public00 
Empleado00 
Empleado00  
{00! "
get00# &
=>00' )
empleado00* 2
;002 3
set004 7
=>008 :
empleado00; C
=00D E
value00F K
;00K L
}00M N
public11 
Afp11 
Afp11 
{11 
get11 
=>11 
afp11  #
;11# $
set11% (
=>11) +
afp11, /
=110 1
value112 7
;117 8
}119 :
public22 
bool22 
Estado22 
{22 
get22  
=>22! #
estado22$ *
;22* +
set22, /
=>220 2
estado223 9
=22: ;
value22< A
;22A B
}22C D
public77 
Boolean77 
ValidarValorPorHora77 *
(77* +
)77+ ,
{88 	
if99 
(99 
pagoPorHora99 
>=99 
$num99 
&&99 !
pagoPorHora99" -
<=99. 0
$num991 3
)993 4
{:: 
return<< 
true<< 
;<< 
}>> 
return?? 
false?? 
;?? 
}@@ 	
publicBB 
doubleBB &
CalcularAsignacionFamiliarBB 0
(BB0 1
)BB1 2
{CC 	
ifDD 
(DD 
AsignacionFamiliarDD "
)DD" #
{EE 
returnFF 
$numFF 
*FF 
$numFF  
;FF  !
}GG 
returnHH 
$numHH 
;HH 
}II 	
publicMM 
BooleanMM !
ValidarHorasSemanalesMM ,
(MM, -
)MM- .
{NN 	
ifOO 
(OO 
horasSemanaOO 
>=OO 
$numOO  
&&OO! #
horasSemanaOO$ /
<=OO0 2
$numOO3 5
&&OO6 8
horasSemanaOO9 D
%OOD E
$numOOE F
==OOF H
$numOOH I
)OOI J
returnPP 
truePP 
;PP 
returnQQ 
falseQQ 
;QQ 
}RR 	
publicTT 
BooleanTT %
ValidarVigenciaDeContratoTT 0
(TT0 1
)TT1 2
{UU 	
ifVV 
(VV 
fechaFinVV 
>=VV 
DateTimeVV $
.VV$ %
NowVV% (
&&VV) +
estadoVV, 2
)VV3 4
returnWW 
trueWW 
;WW 
returnXX 
falseXX 
;XX 
}YY 	
public[[ 
Boolean[[ %
VerificarContratoAnterior[[ 0
([[0 1
Contrato[[1 9
anterior[[: B
)[[B C
{\\ 	
if]] 
(]] 
fechaInicio]] 
>]] 
anterior]] $
.]]$ %
fechaFin]]% -
)]]- .
{^^ 
return__ 
true__ 
;__ 
}`` 
returnaa 
falseaa 
;aa 
}bb 	
publicdd 
Booleandd 
VerfificarFechaFindd )
(dd) *
)dd* +
{ee 	
ifff 
(ff 
fechaFinff 
>=ff 
fechaInicioff '
.ff' (
	AddMonthsff( 1
(ff1 2
$numff2 3
)ff3 4
&&ff5 7
fechaFinff8 @
<=ffA C
fechaInicioffD O
.ffO P
	AddMonthsffP Y
(ffY Z
$numffZ \
)ff\ ]
)ff] ^
returngg 
truegg 
;gg 
returnhh 
falsehh 
;hh 
}ii 	
}kk 
}ll ∑
XD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\Empleado.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 
Empleado		 
{

 
private 
String 
	direccion  
;  !
private 
String 
dni 
; 
private 
String 
estadoCivil "
;" #
private 
String 
gradoAcademico %
;% &
private 
DateTime 
fechaNacimiento (
;( )
private 
String 
nombre 
; 
private 
String 
telefono 
;  
public 
string 
	Direccion 
{  !
get" %
=>& (
	direccion) 2
;2 3
set4 7
=>8 :
	direccion; D
=E F
valueG L
;L M
}N O
public 
String 
Dni 
{ 
get 
=>  "
dni# &
;& '
set( +
=>, .
dni/ 2
=3 4
value5 :
;: ;
}< =
public 
String 
EstadoCivil !
{" #
get$ '
=>( *
estadoCivil+ 6
;6 7
set8 ;
=>< >
estadoCivil? J
=K L
valueM R
;R S
}T U
public 
string 
GradoAcademico $
{% &
get' *
=>+ -
gradoAcademico. <
;< =
set> A
=>B D
gradoAcademicoE S
=T U
valueV [
;[ \
}] ^
public 
DateTime 
FechaNacimiento '
{( )
get* -
=>. 0
fechaNacimiento1 @
;@ A
setB E
=>F H
fechaNacimientoI X
=Y Z
value[ `
;` a
}b c
public 
string 
Nombre 
{ 
get "
=># %
nombre& ,
;, -
set. 1
=>2 4
nombre5 ;
=< =
value> C
;C D
}E F
public 
String 
Telefono 
{  
get! $
=>% '
telefono( 0
;0 1
set2 5
=>6 8
telefono9 A
=B C
valueD I
;I J
}K L
} 
} «
]D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Entidades\PeriodoDePago.cs
	namespace 	
CapaDominio
 
. 
	Entidades 
{ 
public		 

class		 
PeriodoDePago		 
{

 
private 
int 
codigoPeriodo !
;! "
private 
Boolean 
estado 
; 
private 
DateTime 
fechaInicio $
;$ %
private 
DateTime 
fechaFin !
;! "
private 
float 
semanasDelPeriodo '
;' (
public 
bool 
Estado 
{ 
get  
=>! #
estado$ *
;* +
set, /
=>0 2
estado3 9
=: ;
value< A
;A B
}C D
public 
DateTime 
FechaInicio #
{$ %
get& )
=>* ,
fechaInicio- 8
;8 9
set: =
=>> @
fechaInicioA L
=M N
valueO T
;T U
}V W
public 
DateTime 
FechaFin  
{! "
get# &
=>' )
fechaFin* 2
;2 3
set4 7
=>8 :
fechaFin; C
=D E
valueF K
;K L
}M N
public 
float 
SemanasDelPeriodo &
{' (
get) ,
=>- /
semanasDelPeriodo0 A
;A B
setC F
=>G I
semanasDelPeriodoJ [
=\ ]
value^ c
;c d
}e f
public 
int 
CodigoPeriodo  
{! "
get# &
=>' )
codigoPeriodo* 7
;7 8
set9 <
=>= ?
codigoPeriodo@ M
=N O
valueP U
;U V
}W X
public 
Boolean "
VerificarPeriodoDePago -
(- .
). /
{ 	
if 
( 
DateTime 
. 
Now 
>=  
FechaFin! )
)) *
{ 
return 
true 
; 
} 
else 
{ 
return 
false 
; 
}!! 
}"" 	
public$$ 
int$$ "
CalcularSemanasPeriodo$$ )
($$) *
)$$* +
{%% 	
TimeSpan&& 
	difFechas&& 
=&&  
FechaFin&&! )
-&&* +
FechaInicio&&, 7
;&&7 8
int'' 
day'' 
='' 
	difFechas'' 
.''  
Days''  $
;''$ %
return(( 
day(( 
/(( 
$num(( 
;(( 
})) 	
}** 
}++ ù!
XD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Libreria\Extension.cs
	namespace		 	
CapaDominio		
 
.		 
Libreria		 
{

 
public 

static 
class 
	Extension !
{ 
public 
static 
T 
GetColumnValue &
<& '
T' (
>( )
() *
this* .
SqlDataReader/ <
record= C
,C D
StringE K

columnNameL V
)V W
{ 	
return 
GetColumnValue !
<! "
T" #
># $
($ %
record% +
,+ ,

columnName- 7
,7 8
default9 @
(@ A
TA B
)B C
)C D
;D E
} 	
public 
static 
T 
GetColumnValue &
<& '
T' (
>( )
() *
this* .
SqlDataReader/ <
objDr= B
,B C
StringD J

columnNameK U
,U V
TW X
defaultValueY e
)e f
{ 	
try 
{ 
Object 
value 
= 
objDr $
[$ %

columnName% /
]/ 0
;0 1
if 
( 
value 
== 
null !
||" $
value% *
==+ -
DBNull. 4
.4 5
Value5 :
): ;
{ 
return 
defaultValue '
;' (
} 
else 
{ 
if 
( 
defaultValue $
==% '
null( ,
&&- /
objDr0 5
[5 6

columnName6 @
]@ A
isB D
DateTimeE M
)M N
{ 
DateTime  
date! %
=& '
(( )
DateTime) 1
)1 2
value2 7
;7 8
Object   
sdate   $
=  % &
date  ' +
.  + ,
ToStringDate  , 8
(  8 9
)  9 :
;  : ;
return!! 
(!!  
T!!  !
)!!! "
sdate!!" '
;!!' (
}"" 
if## 
(## 
objDr## 
[## 

columnName## (
]##( )
is##* ,
Int64##- 2
||##3 5
objDr##6 ;
[##; <

columnName##< F
]##F G
is##H J
Int32##K P
||##Q S
objDr##T Y
[##Y Z

columnName##Z d
]##d e
is##f h
Int16##i n
||##o q
objDr##r w
[##w x

columnName	##x Ç
]
##Ç É
is
##Ñ Ü
Byte
##á ã
||
##å é
objDr
##è î
[
##î ï

columnName
##ï ü
]
##ü †
is
##° £
Decimal
##§ ´
||
##¨ Æ
objDr
##Ø ¥
[
##¥ µ

columnName
##µ ø
]
##ø ¿
is
##¡ √
Double
##ƒ  
)
##  À
{$$ 
return%% 
(%%  
T%%  !
)%%! "
Convert%%" )
.%%) *

ChangeType%%* 4
(%%4 5
value%%5 :
,%%: ;
typeof%%< B
(%%B C
T%%C D
)%%D E
)%%E F
;%%F G
}&& 
else'' 
return(( 
(((  
T((  !
)((! "
value((" '
;((' (
})) 
}** 
catch++ 
(++ 
	Exception++ 
)++ 
{,, 
throw-- 
;-- 
}.. 
}// 	
public11 
static11 
String11 
ToStringDate11 )
(11) *
this11* .
DateTime11/ 7
date118 <
)11< =
{22 	
return33 
date33 
.33 
ToString33  
(33  !
$str33! -
,33- .
CultureInfo33/ :
.33: ;
InvariantCulture33; K
)33K L
;33L M
}44 	
}55 
}66 à
]D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str &
)& '
]' (
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
$str (
)( )
]) *
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
]$$) *®!
bD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Servicios\RegistroDeContrato.cs
	namespace 	
CapaDominio
 
. 
	Servicios 
{		 
public

 

class

 
RegistroDeContrato

 #
{ 
public 
Boolean  
validarContratoTotal +
(+ ,
Contrato, 4
contrato5 =
,= >
Empleado? G
empleadoH P
,P Q
AfpR U
afpV Y
,Y Z
Contrato[ c
anteriorContratod t
)t u
{ 	
if 
( 
contrato 
. %
ValidarVigenciaDeContrato 2
(2 3
)3 4
==5 7
false8 =
)= >
{ 
return 
false 
; 
} 
if 
( 
contrato 
. %
VerificarContratoAnterior 2
(2 3
anteriorContrato3 C
)C D
==E G
falseH M
)M N
{ 
return 
false 
; 
} 
if 
( 
contrato 
. 
VerfificarFechaFin +
(+ ,
), -
==. 0
false1 6
)6 7
{ 
return 
false 
; 
} 
if 
( 
contrato 
. !
ValidarHorasSemanales .
(. /
)/ 0
==1 3
false4 9
)9 :
{ 
return!! 
false!! 
;!! 
}"" 
if## 
(## 
contrato## 
.## 
ValidarValorPorHora## ,
(##, -
)##- .
==##/ 1
false##2 7
)##7 8
{$$ 
return&& 
false&& 
;&& 
}'' 
return** 
true** 
;** 
}++ 	
public,, 
Boolean,, 
validarContrato,, &
(,,& '
Contrato,,' /
contrato,,0 8
,,,8 9
Empleado,,: B
empleado,,C K
,,,K L
Afp,,M P
afp,,Q T
),,T U
{-- 	
if.. 
(.. 
contrato.. 
... %
ValidarVigenciaDeContrato.. 2
(..2 3
)..3 4
==..5 7
false..8 =
)..= >
{// 
return11 
false11 
;11 
}22 
if44 
(44 
contrato44 
.44 
VerfificarFechaFin44 +
(44+ ,
)44, -
==44. 0
false441 6
)446 7
{55 
return77 
false77 
;77 
}88 
if99 
(99 
contrato99 
.99 !
ValidarHorasSemanales99 .
(99. /
)99/ 0
==991 3
false994 9
)999 :
{:: 
return<< 
false<< 
;<< 
}== 
if>> 
(>> 
contrato>> 
.>> 
ValidarValorPorHora>> ,
(>>, -
)>>- .
==>>/ 1
false>>2 7
)>>7 8
{?? 
returnAA 
falseAA 
;AA 
}BB 
returnCC 
trueCC 
;CC 
}DD 	
publicFF 
ContratoFF 
editarContratoFF &
(FF& '
ContratoFF' /
contratoFF0 8
,FF8 9
ContratoFF: B
contratoEditadoFFC R
)FFR S
{GG 	
contratoHH 
=HH 
contratoEditadoHH &
;HH& '
returnJJ 
contratoJJ 
;JJ 
}KK 	
publicLL	 
voidLL 
anularContratoLL #
(LL# $
ContratoLL$ ,
contratoLL- 5
)LL5 6
{MM 	
contratoNN 
.NN 
EstadoNN 
=NN 
falseNN #
;NN# $
throwOO 
newOO 
	ExceptionOO 
(OO  
$strOO  3
)OO3 4
;OO4 5
}QQ 	
}RR 
}SS › 
^D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaDominio\Servicios\RegistroDePago.cs
	namespace		 	
CapaDominio		
 
.		 
	Servicios		 
{

 
public 

class 
RegistroDePago 
{ 
public 
void 
RegistrarBoletas $
($ %
PeriodoDePago% 2
periodo3 :
,: ;
List; ?
<? @
Contrato@ H
>H I
	contratosJ S
,S T&
ConceptoDeIngresoDescuentoT n
conceptoo w
)w x
{ 	
if 
( 
periodo 
. "
VerificarPeriodoDePago -
(- .
). /
)/ 0
{ 
List 
< 
BoletaDePago !
>! "
Boletas# *
=+ ,
new- 0
List1 5
<5 6
BoletaDePago6 B
>B C
(C D
)D E
;E F
foreach 
( 
Contrato !
contrato" *
in+ -
	contratos. 7
)7 8
{ 
if 
( 
contrato 
.  
Estado  &
&&' )
contrato* 2
.2 3
FechaFin3 ;
>; <
periodo< C
.C D
FechaInicioD O
)O P
{ 
Boletas 
.  
Add  #
(# $
registrarPago$ 1
(1 2
contrato2 :
,: ;
periodo< C
,C D
conceptoD L
)L M
)M N
;N O
} 
} 
} 
} 	
public 
BoletaDePago 
registrarPago )
() *
Contrato* 2
contrato3 ;
,; <
PeriodoDePago= J
periodoK R
,R S&
ConceptoDeIngresoDescuentoS m
concepton v
)v w
{ 	
BoletaDePago 
boleta 
=  !
new" %
BoletaDePago& 2
(2 3
contrato3 ;
,; <
periodo< C
)C D
;D E
boleta 
. 
TotalDeHoras 
=  
boleta! '
.' ( 
CalcularTotalDeHoras( <
(< =
)= >
;> ?
boleta   
.   
SueldoBasico   
=    !
boleta  " (
.  ( ) 
CalcularSueldoBasico  ) =
(  = >
)  > ?
;  ? @
boleta!! 
.!! 
AsignacionFamiliar!! %
=!!& '
boleta!!( .
.!!. /
Contrato!!/ 7
.!!7 8&
CalcularAsignacionFamiliar!!8 R
(!!R S
)!!S T
;!!T U
boleta"" 
."" 
DescuentoAfp"" 
=""  !
boleta""" (
.""( )!
CalcularDescuentosAfp"") >
(""> ?
boleta""? E
.""E F
SueldoBasico""F R
,""R S
contrato""T \
.""\ ]
Afp""] `
.""` a
PorcentajeAfp""a n
)""n o
;""o p
boleta## 
.## 
TotalDeDescuentos## $
=##% &
boleta##' -
.##- ."
CalcularTotalDescuento##. D
(##D E
boleta##E K
,##K L
concepto##M U
)##U V
;##V W
boleta$$ 
.$$ 
TotalDeIngresos$$ "
=$$# $
boleta$$% +
.$$+ ,#
CalcularTotalDeIngresos$$, C
($$C D
concepto$$E M
,$$M N
contrato$$P X
)$$X Y
;$$Y Z
boleta%% 
.%% 
FechaDeEmision%% !
=%%" #
DateTime%%$ ,
.%%, -
Now%%- 0
;%%0 1
boleta&& 
.&& 

SueldoNeto&& 
=&& 
boleta&&  &
.&&& '
CalcularSueldoNeto&&' 9
(&&9 :
)&&: ;
;&&; <
return)) 
boleta)) 
;)) 
}** 	
}++ 
},, 