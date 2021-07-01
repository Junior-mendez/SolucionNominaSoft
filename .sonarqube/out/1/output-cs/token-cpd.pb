Ë
_D:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\AfpDAO.cs
	namespace 	
CapaPersistencia
 
. 
ADO_SQLServer (
{ 
public 

class 
AfpDAO 
: 
IAfp 
{ 
private 
	GestorSQL 
	gestorSQL #
;# $
public 
AfpDAO 
( 
IGestorAccesoADatos )
	gestorSQL* 3
)3 4
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
} 	
public 
Afp 
buscarPorCodigo "
(" #
string# )
nombre* 0
)0 1
{ 	
Afp 
afp 
; 
string 
storeProcedureSql $
=% &
$str' ;
;; <
try 
{ 

SqlCommand 
command "
;" #
command 
= 
	gestorSQL #
.# $)
obtenerComandoDeProcedimiento$ A
(A B
storeProcedureSqlB S
)S T
;T U
command 
. 

Parameters "
." #
AddWithValue# /
(/ 0
$str0 9
,9 :
nombre; A
)A B
;B C
SqlDataReader   
	resultSql   '
=  ( )
command  * 1
.  1 2
ExecuteReader  2 ?
(  ? @
)  @ A
;  A B
if!! 
(!! 
	resultSql!! 
.!! 
Read!! "
(!!" #
)!!# $
)!!$ %
{"" 
afp## 
=## 

obtenerAfp## $
(##$ %
	resultSql##% .
)##. /
;##/ 0
}$$ 
else%% 
{&& 
throw'' 
new'' 
	Exception'' '
(''' (
$str''( F
)''F G
;''G H
}(( 
})) 
catch** 
(** 
	Exception** 
err**  
)**  !
{++ 
throw,, 
err,, 
;,, 
}-- 
return.. 
afp.. 
;.. 
}// 	
private11 
Afp11 

obtenerAfp11 
(11 
SqlDataReader11 ,
resultadoSQL11- 9
)119 :
{22 	
Afp33 
afp33 
=33 
new33 
Afp33 
(33 
)33 
{44 
	CodigoAfp55 
=55 
resultadoSQL55 (
.55( )
GetColumnValue55) 7
<557 8
int558 ;
>55; <
(55< =
$str55= H
)55H I
,55I J
	NombreAfp66 
=66 
resultadoSQL66 (
.66( )
GetColumnValue66) 7
<667 8
String668 >
>66> ?
(66? @
$str66@ K
)66K L
,66L M
PorcentajeAfp77 
=77 
resultadoSQL77  ,
.77, -
GetColumnValue77- ;
<77; <
float77< A
>77A B
(77B C
$str77C R
)77R S
}88 
;88 
return99 
afp99 
;99 
}:: 	
}?? 
}@@ ä"
hD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\BoletaDePagoDAO.cs
	namespace

 	
CapaPersistencia


 
.

 
ADO_SQLServer

 (
{ 
public 

class 
BoletaDePagoDAO  
:! "
IBoleta" )
{ 
private 
	GestorSQL 
	gestorSQL #
;# $
public 
BoletaDePagoDAO 
( 
IGestorAccesoADatos 2
	gestorSQL3 <
)< =
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
} 	
public 
void 
guardarBoleta !
(! "
BoletaDePago" .
boleta/ 5
)5 6
{ 	
string 
sqlProcedure 
=  !
$str" 9
;9 :
try 
{ 

SqlCommand 
comando "
=# $
	gestorSQL% .
.. /)
obtenerComandoDeProcedimiento/ L
(L M
sqlProcedureM Y
)Y Z
;Z [
comando 
. 

Parameters "
." #
AddWithValue# /
(/ 0
$str0 E
,E F
boletaG M
.M N
AsignacionFamiliarN `
)` a
;a b
comando 
. 

Parameters "
." #
AddWithValue# /
(/ 0
$str0 A
,A B
boletaC I
.I J
FechaDeEmisionJ X
)X Y
;Y Z
comando 
. 

Parameters "
." #
AddWithValue# /
(/ 0
$str0 ?
,? @
boletaA G
.G H
SueldoBasicoH T
)T U
;U V
comando   
.   

Parameters   "
.  " #
AddWithValue  # /
(  / 0
$str  0 =
,  = >
boleta  ? E
.  E F

SueldoNeto  F P
)  P Q
;  Q R
comando!! 
.!! 

Parameters!! "
.!!" #
AddWithValue!!# /
(!!/ 0
$str!!0 6
,!!6 7
boleta!!8 >
.!!> ?
DescuentoAfp!!? K
)!!K L
;!!L M
comando"" 
."" 

Parameters"" "
.""" #
AddWithValue""# /
(""/ 0
$str""0 ?
,""? @
boleta""A G
.""G H
TotalDeHoras""H T
)""T U
;""U V
comando## 
.## 

Parameters## "
.##" #
AddWithValue### /
(##/ 0
$str##0 D
,##D E
boleta##F L
.##L M
TotalDeDescuentos##M ^
)##^ _
;##_ `
comando$$ 
.$$ 

Parameters$$ "
.$$" #
AddWithValue$$# /
($$/ 0
$str$$0 B
,$$B C
boleta$$D J
.$$J K
TotalDeIngresos$$K Z
)$$Z [
;$$[ \
comando%% 
.%% 

Parameters%% "
.%%" #
AddWithValue%%# /
(%%/ 0
$str%%0 A
,%%A B
boleta%%C I
.%%I J
Contrato%%J R
.%%R S
Codigo%%S Y
)%%Y Z
;%%Z [
comando&& 
.&& 

Parameters&& "
.&&" #
AddWithValue&&# /
(&&/ 0
$str&&0 O
,&&O P
boleta&&Q W
.&&W X&
ConceptoDeIngresoDescuento&&X r
.&&r s
CodigoConcepto	&&s Å
)
&&Å Ç
;
&&Ç É
comando'' 
.'' 

Parameters'' "
.''" #
AddWithValue''# /
(''/ 0
$str''0 B
,''B C
boleta''D J
.''J K
PeriodoDePago''K X
.''X Y
CodigoPeriodo''Y f
)''f g
;''g h
comando)) 
.)) 
ExecuteNonQuery)) '
())' (
)))( )
;))) *
}** 
catch++ 
(++ 
	Exception++ 
err++  
)++  !
{,, 
throw-- 
err-- 
;-- 
}.. 
}00 	
}33 
}44 Ÿ/
vD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\ConceptoDeIngresoDescuentoDAO.cs
	namespace 	
CapaPersistencia
 
. 
ADO_SQLServer (
{ 
public 

class )
ConceptoDeIngresoDescuentoDAO .
:/ 0
	IConcepto0 9
{ 
private 
PeriodoDePagoDAO  
periodoDePagoDAO! 1
;1 2
private 
ContratoDAO 
contratoDAO '
;' (
private 
	GestorSQL 
	gestorSQL #
;# $
public )
ConceptoDeIngresoDescuentoDAO ,
(, -
IGestorAccesoADatos- @
	gestorSQLA J
,J K
IPeriodoL T
periodoDePagoDAOU e
,e f
	IContratog p
contratoDAOq |
)| }
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
this 
. 
contratoDAO 
= 
(  
ContratoDAO  +
)+ ,
contratoDAO, 7
;7 8
this 
. 
periodoDePagoDAO !
=" #
($ %
PeriodoDePagoDAO% 5
)5 6
periodoDePagoDAO6 F
;F G
} 	
private &
ConceptoDeIngresoDescuento *
obtenerConceptos+ ;
(; <
SqlDataReader< I
resultadoSQLJ V
,V W
PeriodoDePagoW d
periodoe l
)l m
{ 	&
ConceptoDeIngresoDescuento &(
conceptoDeIngresosDescuentos' C
=D E
newF I&
ConceptoDeIngresoDescuentoJ d
(d e
periodoe l
)l m
;m n(
conceptoDeIngresosDescuentos (
.( )"
MontoDeOtrosDescuentos) ?
=@ A
resultadoSQLB N
.N O
GetColumnValueO ]
<] ^
Double^ d
>d e
(e f
$strf ~
)~ 
;	 Ä(
conceptoDeIngresosDescuentos   (
.  ( ) 
MontoDeOtrosIngresos  ) =
=  > ?
resultadoSQL  @ L
.  L M
GetColumnValue  M [
<  [ \
Double  \ b
>  b c
(  c d
$str  d z
)  z {
;  { |(
conceptoDeIngresosDescuentos!! (
.!!( )
MontoPorAdelantos!!) :
=!!; <
resultadoSQL!!= I
.!!I J
GetColumnValue!!J X
<!!X Y
Double!!Y _
>!!_ `
(!!` a
$str!!a t
)!!t u
;!!u v(
conceptoDeIngresosDescuentos"" (
.""( )!
MontoPorHorasAusentes"") >
=""? @
resultadoSQL""A M
.""M N
GetColumnValue""N \
<""\ ]
Double""] c
>""c d
(""d e
$str""e |
)""| }
;""} ~(
conceptoDeIngresosDescuentos## (
.##( )
MontoPorHorasExtras##) <
=##= >
resultadoSQL##? K
.##K L
GetColumnValue##L Z
<##Z [
Double##[ a
>##a b
(##b c
$str##c w
)##w x
;##x y(
conceptoDeIngresosDescuentos$$ (
.$$( )
MontoPorReintegros$$) ;
=$$< =
resultadoSQL$$> J
.$$J K
GetColumnValue$$K Y
<$$Y Z
Double$$Z `
>$$` a
($$a b
$str$$b v
)$$v w
;$$w x(
conceptoDeIngresosDescuentos%% (
.%%( )
CodigoConcepto%%) 7
=%%8 9
resultadoSQL%%: F
.%%F G
GetColumnValue%%G U
<%%U V
int%%V Y
>%%Y Z
(%%Z [
$str%%[ k
)%%k l
;%%l m
periodo&& 
.&& 
CodigoPeriodo&& !
=&&" #
resultadoSQL&&$ 0
.&&0 1
GetColumnValue&&1 ?
<&&? @
int&&@ C
>&&C D
(&&D E
$str&&E T
)&&T U
;&&U V
return'' (
conceptoDeIngresosDescuentos'' /
;''/ 0
}(( 	
public** &
ConceptoDeIngresoDescuento** )
buscarConcepto*** 8
(**8 9
Contrato**9 A
contrato**B J
,**J K
PeriodoDePago**L Y
periodoDePago**Z g
)**g h
{++ 	&
ConceptoDeIngresoDescuento,, &
concepto,,' /
=,,0 1
new,,2 5&
ConceptoDeIngresoDescuento,,6 P
(,,P Q
periodoDePago,,Q ^
),,^ _
;,,_ `
String-- 
consultaSQL-- 
=--  
$str	--! ç
+
--é è
contrato
--ê ò
.
--ò ô
Codigo
--ô ü
+
--† °
$str
--¢ ª
+
--º Ω
periodoDePago
--æ À
.
--À Ã
CodigoPeriodo
--Ã Ÿ
+
--⁄ €
$str
--‹ ‡
;
--‡ ·
try.. 
{// 
SqlDataReader00 
resultadoSQL00 *
=00+ ,
	gestorSQL00- 6
.006 7
ejecutarConsulta007 G
(00G H
consultaSQL00H S
)00S T
;00T U
if11 
(11 
resultadoSQL11  
.11  !
Read11! %
(11% &
)11& '
)11' (
{22 
concepto33 
=33 
obtenerConceptos33 /
(33/ 0
resultadoSQL330 <
,33< =
periodoDePago33= J
)33J K
;33K L
}44 
else55 
{66 
throw77 
new77 
	Exception77 '
(77' (
$str77( ?
)77? @
;77@ A
}88 
}99 
catch:: 
(:: 
	Exception:: 
err::  
)::  !
{;; 
throw<< 
err<< 
;<< 
}== 
return>> 
concepto>> 
;>> 
}?? 	
}@@ 
}AA ¸ù
dD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\ContratoDAO.cs
	namespace 	
CapaPersistencia
 
. 
ADO_SQLServer (
{ 
public 

class 
ContratoDAO 
: 
	IContrato '
{ 
private 
	GestorSQL 
	gestorSQL #
;# $
private 
EmpleadoDAO 
empleadoDAO '
;' (
private 
AfpDAO 
afpDAO 
; 
public 
ContratoDAO 
( 
IGestorAccesoADatos .
	gestorSQL/ 8
,8 9
	IEmpleado9 B
empleadoDAOC N
,N O
IAfpP T
afpDAOU [
)[ \
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
this 
. 
empleadoDAO 
= 
(  
EmpleadoDAO  +
)+ ,
empleadoDAO, 7
;7 8
this 
. 
afpDAO 
= 
( 
AfpDAO !
)! "
afpDAO" (
;( )
} 	
public 
void 
crearContrato !
(! "
Contrato" *
contrato+ 3
,3 4
Empleado4 <
empleado= E
,E F
AfpF I
afpJ M
)M N
{ 	
string 
crearContrato  
=! "
$str	# •
+
¶ ß
$str	 É
;
É Ñ
try   
{!! 

SqlCommand"" 
comando"" "
;""" #
comando$$ 
=$$ 
	gestorSQL$$ #
.$$# $
obtenerComandoSQL$$$ 5
($$5 6
crearContrato$$6 C
)$$C D
;$$D E
comando%% 
.%% 

Parameters%% "
.%%" #
AddWithValue%%# /
(%%/ 0
$str%%0 E
,%%E F
contrato%%G O
.%%O P
AsignacionFamiliar%%P b
)%%b c
;%%c d
comando&& 
.&& 

Parameters&& "
.&&" #
AddWithValue&&# /
(&&/ 0
$str&&0 8
,&&8 9
contrato&&: B
.&&B C
Cargo&&C H
)&&H I
;&&I J
comando'' 
.'' 

Parameters'' "
.''" #
AddWithValue''# /
(''/ 0
$str''0 >
,''> ?
contrato''@ H
.''H I
FechaInicio''I T
)''T U
;''U V
comando(( 
.(( 

Parameters(( "
.((" #
AddWithValue((# /
(((/ 0
$str((0 ;
,((; <
contrato((= E
.((E F
FechaFin((F N
)((N O
;((O P
comando)) 
.)) 

Parameters)) "
.))" #
AddWithValue))# /
())/ 0
$str))0 >
,))> ?
contrato))@ H
.))H I
HorasSemana))I T
)))T U
;))U V
comando** 
.** 

Parameters** "
.**" #
AddWithValue**# /
(**/ 0
$str**0 >
,**> ?
contrato**@ H
.**H I
PagoPorHora**I T
)**T U
;**U V
comando++ 
.++ 

Parameters++ "
.++" #
AddWithValue++# /
(++/ 0
$str++0 9
,++9 :
contrato++; C
.++C D
Estado++D J
)++J K
;++K L
comando,, 
.,, 

Parameters,, "
.,," #
AddWithValue,,# /
(,,/ 0
$str,,0 ;
,,,; <
empleado,,= E
.,,E F
Dni,,F I
),,I J
;,,J K
comando-- 
.-- 

Parameters-- "
.--" #
AddWithValue--# /
(--/ 0
$str--0 6
,--6 7
afp--8 ;
.--; <
	CodigoAfp--< E
)--E F
;--F G
comando// 
.// 
ExecuteNonQuery// '
(//' (
)//( )
;//) *
}00 
catch11 
(11 
	Exception11 
err11  
)11  !
{22 
throw33 
err33 
;33 
}44 
}55 	
public77 
List77 
<77 
Contrato77 
>77 
listarContrato77 ,
(77, -
string77- 3
estado774 :
,77: ;
DateTime77; C
fechaInicio77D O
,77O P
DateTime77Q Y
fechaFin77Z b
)77b c
{88 	
List99 
<99 
Contrato99 
>99 
listaDeContratos99 +
=99, -
new99. 1
List992 6
<996 7
Contrato997 ?
>99? @
(99@ A
)99A B
;99B C
Contrato:: 
contrato:: 
;:: 
string<< 
storeProcedureSql<< $
=<<% &
$str<<' 7
;<<7 8
try>> 
{?? 

SqlCommand@@ 
command@@ "
;@@" #
commandAA 
=AA 
	gestorSQLAA #
.AA# $)
obtenerComandoDeProcedimientoAA$ A
(AAA B
storeProcedureSqlAAB S
)AAS T
;AAT U
commandBB 
.BB 

ParametersBB "
.BB" #
AddWithValueBB# /
(BB/ 0
$strBB0 9
,BB9 :
estadoBB; A
)BBA B
;BBB C
commandCC 
.CC 

ParametersCC "
.CC" #
AddWithValueCC# /
(CC/ 0
$strCC0 ;
,CC; <
fechaInicioCC= H
)CCH I
;CCI J
commandDD 
.DD 

ParametersDD "
.DD" #
AddWithValueDD# /
(DD/ 0
$strDD0 ;
,DD; <
fechaFinDD= E
)DDE F
;DDF G
SqlDataReaderEE 
	resultSqlEE '
=EE( )
commandEE* 1
.EE1 2
ExecuteReaderEE2 ?
(EE? @
)EE@ A
;EEA B
whileFF 
(FF 
	resultSqlFF  
.FF  !
ReadFF! %
(FF% &
)FF& '
)FF' (
{GG 
contratoHH 
=HH 
obtenerContratoHH .
(HH. /
	resultSqlHH/ 8
)HH8 9
;HH9 :
listaDeContratosII $
.II$ %
AddII% (
(II( )
contratoII) 1
)II1 2
;II2 3
}JJ 
}KK 
catchLL 
(LL 
	ExceptionLL 
errLL  
)LL  !
{MM 
throwNN 
errNN 
;NN 
}OO 
returnPP 
listaDeContratosPP #
;PP# $
}QQ 	
publicSS 
ContratoSS  
buscarUltimoContratoSS ,
(SS, -
stringSS- 3
dniSS4 7
)SS7 8
{TT 	
AfpUU 
afpUU 
=UU 
newUU 
AfpUU 
(UU 
)UU 
;UU  
ContratoVV 
contratoVV 
=VV 
newVV  #
ContratoVV$ ,
(VV, -
afpVV- 0
)VV0 1
;VV1 2
stringWW 
storeProcedureSQLWW $
=WW% &
$strWW' =
;WW= >
tryXX 
{YY 

SqlCommandZZ 
commandZZ "
;ZZ" #
command[[ 
=[[ 
	gestorSQL[[ #
.[[# $)
obtenerComandoDeProcedimiento[[$ A
([[A B
storeProcedureSQL[[B S
)[[S T
;[[T U
command\\ 
.\\ 

Parameters\\ "
.\\" #
AddWithValue\\# /
(\\/ 0
$str\\0 6
,\\6 7
dni\\8 ;
)\\; <
;\\< =
SqlDataReader]] 
	resultSql]] '
=]]( )
command]]* 1
.]]1 2
ExecuteReader]]2 ?
(]]? @
)]]@ A
;]]A B
if^^ 
(^^ 
	resultSql^^ 
.^^ 
Read^^ "
(^^" #
)^^# $
)^^$ %
{__ 
contrato`` 
=`` 
obtenerContrato`` .
(``. /
	resultSql``/ 8
)``8 9
;``9 :
}aa 
elsebb 
{cc 
throwdd 
newdd 
	Exceptiondd '
(dd' (
$strdd( @
)dd@ A
;ddA B
}ff 
}gg 
catchhh 
(hh 
	Exceptionhh 
)hh 
{ii 
throwjj 
;jj 
}kk 
returnll 
contratoll 
;ll 
}mm 	
publicoo 
Contratooo 
buscarContratooo &
(oo& '
intoo' *
dnioo+ .
)oo. /
{pp 	
Contratoqq 
contratoqq 
;qq 
stringrr 
storeProcedureSqlrr $
=rr% &
$strrr' ;
;rr; <
tryss 
{tt 

SqlCommanduu 
commanduu "
;uu" #
commandvv 
=vv 
	gestorSQLvv #
.vv# $)
obtenerComandoDeProcedimientovv$ A
(vvA B
storeProcedureSqlvvB S
)vvS T
;vvT U
commandww 
.ww 

Parametersww "
.ww" #
AddWithValueww# /
(ww/ 0
$strww0 6
,ww6 7
dniww8 ;
)ww; <
;ww< =
SqlDataReaderxx 
	resultSqlxx '
=xx( )
commandxx* 1
.xx1 2
ExecuteReaderxx2 ?
(xx? @
)xx@ A
;xxA B
ifyy 
(yy 
	resultSqlyy 
.yy 
Readyy "
(yy" #
)yy# $
)yy$ %
{zz 
contrato{{ 
={{ 
obtenerContrato{{ .
({{. /
	resultSql{{/ 8
){{8 9
;{{9 :
}|| 
else}} 
{~~ 
throw 
new 
	Exception '
(' (
$str( @
)@ A
;A B
}
ÄÄ 
}
ÅÅ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
err
ÇÇ  
)
ÇÇ  !
{
ÉÉ 
throw
ÑÑ 
err
ÑÑ 
;
ÑÑ 
}
ÖÖ 
return
ÜÜ 
contrato
ÜÜ 
;
ÜÜ 
}
áá 	
private
ââ 
Contrato
ââ 
obtenerContrato
ââ (
(
ââ( )
SqlDataReader
ââ) 6
resultadoSQL
ââ7 C
)
ââC D
{
ää 	
Afp
ãã 
afp
ãã 
=
ãã 
new
ãã 
Afp
ãã 
(
ãã 
)
ãã 
;
ãã  
Empleado
åå 
empleado
åå 
=
åå 
new
åå  #
Empleado
åå$ ,
(
åå, -
)
åå- .
;
åå. /
Contrato
çç 
contrato
çç 
=
çç 
new
çç  #
Contrato
çç$ ,
(
çç, -
afp
çç. 1
,
çç1 2
empleado
çç3 ;
)
çç; <
;
çç< =
contrato
èè 
.
èè 
Codigo
èè 
=
èè 
resultadoSQL
èè *
.
èè* +
GetColumnValue
èè+ 9
<
èè9 :
int
èè: =
>
èè= >
(
èè> ?
$str
èè? O
)
èèO P
;
èèP Q
contrato
êê 
.
êê 
Cargo
êê 
=
êê 
resultadoSQL
êê )
.
êê) *
GetColumnValue
êê* 8
<
êê8 9
String
êê9 ?
>
êê? @
(
êê@ A
$str
êêA H
)
êêH I
;
êêI J
contrato
ëë 
.
ëë 
PagoPorHora
ëë  
=
ëë! "
resultadoSQL
ëë# /
.
ëë/ 0
GetColumnValue
ëë0 >
<
ëë> ?
double
ëë? E
>
ëëE F
(
ëëF G
$str
ëëG T
)
ëëT U
;
ëëU V
contrato
íí 
.
íí 
HorasSemana
íí  
=
íí! "
resultadoSQL
íí# /
.
íí/ 0
GetColumnValue
íí0 >
<
íí> ?
int
íí? B
>
ííB C
(
ííC D
$str
ííD Q
)
ííQ R
;
ííR S
contrato
ìì 
.
ìì 
Estado
ìì 
=
ìì 
resultadoSQL
ìì *
.
ìì* +
GetColumnValue
ìì+ 9
<
ìì9 :
Boolean
ìì: A
>
ììA B
(
ììB C
$str
ììC K
)
ììK L
;
ììL M
contrato
îî 
.
îî 
FechaInicio
îî  
=
îî! "
resultadoSQL
îî# /
.
îî/ 0
GetColumnValue
îî0 >
<
îî> ?
DateTime
îî? G
>
îîG H
(
îîH I
$str
îîI V
)
îîV W
;
îîW X
contrato
ïï 
.
ïï 
FechaFin
ïï 
=
ïï 
resultadoSQL
ïï  ,
.
ïï, -
GetColumnValue
ïï- ;
<
ïï; <
DateTime
ïï< D
>
ïïD E
(
ïïE F
$str
ïïF P
)
ïïP Q
;
ïïQ R
contrato
ññ 
.
ññ  
AsignacionFamiliar
ññ '
=
ññ( )
resultadoSQL
ññ* 6
.
ññ6 7
GetColumnValue
ññ7 E
<
ññE F
Boolean
ññF M
>
ññM N
(
ññN O
$str
ññO c
)
ññc d
;
ññd e
afp
óó 
.
óó 
	CodigoAfp
óó 
=
óó 
resultadoSQL
óó (
.
óó( )
GetColumnValue
óó) 7
<
óó7 8
int
óó8 ;
>
óó; <
(
óó< =
$str
óó= H
)
óóH I
;
óóI J
afp
òò 
.
òò 
	NombreAfp
òò 
=
òò 
resultadoSQL
òò (
.
òò( )
GetColumnValue
òò) 7
<
òò7 8
String
òò8 >
>
òò> ?
(
òò? @
$str
òò@ K
)
òòK L
;
òòL M
afp
ôô 
.
ôô 
PorcentajeAfp
ôô 
=
ôô 
resultadoSQL
ôô  ,
.
ôô, -
GetColumnValue
ôô- ;
<
ôô; <
float
ôô< A
>
ôôA B
(
ôôB C
$str
ôôC R
)
ôôR S
;
ôôS T
empleado
öö 
.
öö 
Dni
öö 
=
öö 
resultadoSQL
öö '
.
öö' (
GetColumnValue
öö( 6
<
öö6 7
String
öö7 =
>
öö= >
(
öö> ?
$str
öö? L
)
ööL M
;
ööM N
empleado
õõ 
.
õõ 
Nombre
õõ 
=
õõ 
resultadoSQL
õõ *
.
õõ* +
GetColumnValue
õõ+ 9
<
õõ9 :
String
õõ: @
>
õõ@ A
(
õõA B
$str
õõB J
)
õõJ K
;
õõK L
return
úú 
contrato
úú 
;
úú 
}
ùù 	
public
üü 
void
üü 
editarContrato
üü "
(
üü" #
Contrato
üü# +
contrato
üü, 4
)
üü4 5
{
†† 	
int
°° 
codigo
°° 
=
°° 
contrato
°° !
.
°°! "
Codigo
°°" (
;
°°( )
string
¢¢ 
cargo
¢¢ 
=
¢¢ 
contrato
¢¢ #
.
¢¢# $
Cargo
¢¢$ )
;
¢¢) *
double
££ 
pago
££ 
=
££ 
contrato
££ "
.
££" #
PagoPorHora
££# .
;
££. /
int
§§ 
horas
§§ 
=
§§ 
contrato
§§  
.
§§  !
HorasSemana
§§! ,
;
§§, -
DateTime
•• 
fechaIni
•• 
=
•• 
contrato
••  (
.
••( )
FechaInicio
••) 4
;
••4 5
DateTime
¶¶ 
fechaFin
¶¶ 
=
¶¶ 
contrato
¶¶  (
.
¶¶( )
FechaFin
¶¶) 1
;
¶¶1 2
int
ßß 
	codigoAfp
ßß 
=
ßß 
contrato
ßß $
.
ßß$ %
Afp
ßß% (
.
ßß( )
	CodigoAfp
ßß) 2
;
ßß2 3
Boolean
®® 
asigFam
®® 
=
®® 
contrato
®® &
.
®®& ' 
AsignacionFamiliar
®®' 9
;
®®9 :

SqlCommand
™™ 
comando
™™ 
;
™™ 
string
´´ 
consultaSQL
´´ 
=
´´  
$str´´! ê
+´´ë í
$str
¨¨ }
+
¨¨~ 
codigo¨¨Ä Ü
+¨¨á à
$str¨¨â å
;¨¨å ç
try
ÆÆ 
{
ØØ 
comando
∞∞ 
=
∞∞ 
	gestorSQL
∞∞ #
.
∞∞# $
obtenerComandoSQL
∞∞$ 5
(
∞∞5 6
consultaSQL
∞∞6 A
)
∞∞A B
;
∞∞B C
comando
±± 
.
±± 

Parameters
±± "
.
±±" #
AddWithValue
±±# /
(
±±/ 0
$str
±±0 8
,
±±8 9
cargo
±±: ?
)
±±? @
;
±±@ A
comando
≤≤ 
.
≤≤ 

Parameters
≤≤ "
.
≤≤" #
AddWithValue
≤≤# /
(
≤≤/ 0
$str
≤≤0 >
,
≤≤> ?
pago
≤≤@ D
)
≤≤D E
;
≤≤E F
comando
≥≥ 
.
≥≥ 

Parameters
≥≥ "
.
≥≥" #
AddWithValue
≥≥# /
(
≥≥/ 0
$str
≥≥0 >
,
≥≥> ?
horas
≥≥@ E
)
≥≥E F
;
≥≥F G
comando
¥¥ 
.
¥¥ 

Parameters
¥¥ "
.
¥¥" #
AddWithValue
¥¥# /
(
¥¥/ 0
$str
¥¥0 >
,
¥¥> ?
fechaIni
¥¥@ H
)
¥¥H I
;
¥¥I J
comando
µµ 
.
µµ 

Parameters
µµ "
.
µµ" #
AddWithValue
µµ# /
(
µµ/ 0
$str
µµ0 ;
,
µµ; <
fechaFin
µµ= E
)
µµE F
;
µµF G
comando
∂∂ 
.
∂∂ 

Parameters
∂∂ "
.
∂∂" #
AddWithValue
∂∂# /
(
∂∂/ 0
$str
∂∂0 <
,
∂∂< =
	codigoAfp
∂∂> G
)
∂∂G H
;
∂∂H I
comando
∑∑ 
.
∑∑ 

Parameters
∑∑ "
.
∑∑" #
AddWithValue
∑∑# /
(
∑∑/ 0
$str
∑∑0 E
,
∑∑E F
asigFam
∑∑G N
)
∑∑N O
;
∑∑O P
comando
ππ 
.
ππ 
ExecuteNonQuery
ππ '
(
ππ' (
)
ππ( )
;
ππ) *
}
∫∫ 
catch
ªª 
(
ªª 
	Exception
ªª 
err
ªª  
)
ªª  !
{
ºº 
throw
ΩΩ 
err
ΩΩ 
;
ΩΩ 
}
ææ 
}
¿¿ 	
public
¬¬ 
void
¬¬ 
anularContrato
¬¬ "
(
¬¬" #
Contrato
¬¬# +
contrato
¬¬, 4
)
¬¬4 5
{
√√ 	

SqlCommand
≈≈ 
comando
≈≈ 
;
≈≈ 
string
«« 
consultaSQL
«« 
=
««  
$str
««! ]
+
««^ _
contrato
««` h
.
««h i
Codigo
««i o
+
««p q
$str
««r u
;
««u v
try
…… 
{
   
comando
ÀÀ 
=
ÀÀ 
	gestorSQL
ÀÀ #
.
ÀÀ# $
obtenerComandoSQL
ÀÀ$ 5
(
ÀÀ5 6
consultaSQL
ÀÀ6 A
)
ÀÀA B
;
ÀÀB C
comando
ÃÃ 
.
ÃÃ 

Parameters
ÃÃ "
.
ÃÃ" #
AddWithValue
ÃÃ# /
(
ÃÃ/ 0
$str
ÃÃ0 9
,
ÃÃ9 :
Convert
ÃÃ; B
.
ÃÃB C
ToInt32
ÃÃC J
(
ÃÃJ K
contrato
ÃÃK S
.
ÃÃS T
Estado
ÃÃT Z
)
ÃÃZ [
)
ÃÃ[ \
;
ÃÃ\ ]
comando
ŒŒ 
.
ŒŒ 
ExecuteNonQuery
ŒŒ '
(
ŒŒ' (
)
ŒŒ( )
;
ŒŒ) *
}
œœ 
catch
–– 
(
–– 
	Exception
–– 
err
––  
)
––  !
{
—— 
throw
““ 
err
““ 
;
““ 
}
”” 
}
’’ 	
}
÷÷ 
}◊◊ Ñ%
dD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\EmpleadoDAO.cs
	namespace 	
CapaPersistencia
 
. 
ADO_SQLServer (
{ 
public 

class 
EmpleadoDAO 
: 
	IEmpleado '
{ 
private 
	GestorSQL 
	gestorSQL #
;# $
public 
EmpleadoDAO 
( 
IGestorAccesoADatos .
	gestorSQL/ 8
)8 9
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
} 	
public 
Empleado 
buscarPorDni $
($ %
string% +
dni, /
)/ 0
{ 	
Empleado 
empleado 
; 
string 
storeProcedureSql $
=% &
$str' ;
;; <
try 
{ 

SqlCommand 
command "
;" #
if 
( 
! 
string 
. 
IsNullOrEmpty )
() *
dni* -
)- .
). /
{ 
command 
= 
	gestorSQL '
.' ()
obtenerComandoDeProcedimiento( E
(E F
storeProcedureSqlF W
)W X
;X Y
command   
.   

Parameters   &
.  & '
AddWithValue  ' 3
(  3 4
$str  4 :
,  : ;
dni  < ?
)  ? @
;  @ A
SqlDataReader!! !
	resultSql!!" +
=!!, -
command!!. 5
.!!5 6
ExecuteReader!!6 C
(!!C D
)!!D E
;!!E F
if"" 
("" 
	resultSql"" !
.""! "
Read""" &
(""& '
)""' (
)""( )
{## 
empleado$$  
=$$! "
obtenerEmpleado$$# 2
($$2 3
	resultSql$$3 <
)$$< =
;$$= >
}%% 
else&& 
{'' 
throw(( 
new(( !
	Exception((" +
(((+ ,
$str((, A
)((A B
;((B C
})) 
}** 
else++ 
{,, 
throw-- 
new-- 
	Exception-- '
(--' (
$str--( I
)--I J
;--J K
}.. 
}// 
catch00 
(00 
	Exception00 
	exception00 &
)00& '
{11 
throw22 
	exception22 
;22  
}33 
return44 
empleado44 
;44 
}55 	
private77 
Empleado77 
obtenerEmpleado77 (
(77( )
SqlDataReader77) 6
resultadoSQL777 C
)77C D
{88 	
Empleado99 
empleado99 
=99 
new99  #
Empleado99$ ,
{99- .
	Direccion:: 
=:: 
resultadoSQL:: $
.::$ %
GetColumnValue::% 3
<::3 4
String::4 :
>::: ;
(::; <
$str::< G
)::G H
,::H I
Dni;; 
=;; 
resultadoSQL;; 
.;; 
GetColumnValue;; -
<;;- .
String;;. 4
>;;4 5
(;;5 6
$str;;6 ;
);;; <
,;;< =
EstadoCivil<< 
=<< 
resultadoSQL<< &
.<<& '
GetColumnValue<<' 5
<<<5 6
String<<6 <
><<< =
(<<= >
$str<<> K
)<<K L
,<<L M
GradoAcademico== 
=== 
resultadoSQL== )
.==) *
GetColumnValue==* 8
<==8 9
String==9 ?
>==? @
(==@ A
$str==A Q
)==Q R
,==R S
FechaNacimiento>> 
=>> 
resultadoSQL>> *
.>>* +
GetColumnValue>>+ 9
<>>9 :
DateTime>>: B
>>>B C
(>>C D
$str>>D U
)>>U V
,>>V W
Nombre?? 
=?? 
resultadoSQL?? !
.??! "
GetColumnValue??" 0
<??0 1
String??1 7
>??7 8
(??8 9
$str??9 A
)??A B
,??B C
Telefono@@ 
=@@ 
resultadoSQL@@ #
.@@# $
GetColumnValue@@$ 2
<@@2 3
String@@3 9
>@@9 :
(@@: ;
$str@@; E
)@@E F
}AA 
;AA 
returnBB 
empleadoBB 
;BB 
}CC 	
}FF 
}GG ú<
bD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\GestorSQL.cs
	namespace

 	
CapaPersistencia


 
.

 
ADO_SQLServer

 (
{ 
public 

class 
	GestorSQL 
: 
IGestorAccesoADatos 0
{ 
private 
SqlConnection 
conexion &
;& '
private 
SqlTransaction 
transaccion *
;* +
public 
void 
abrirConexion !
(! "
)" #
{ 	
try 
{ 
conexion 
= 
new 
SqlConnection ,
(, -
)- .
;. /
conexion 
. 
ConnectionString )
=* +
$str	, ¥
;
¥ µ
conexion 
. 
Open 
( 
) 
;  
} 
catch 
( 
	Exception 
err  
)  !
{ 
throw 
new 
	Exception #
(# $
$str$ P
,P Q
errR U
)U V
;V W
} 
} 	
public!! 
void!! 
cerrarConexion!! "
(!!" #
)!!# $
{"" 	
try## 
{$$ 
conexion%% 
.%% 
Close%% 
(%% 
)%%  
;%%  !
}&& 
catch'' 
('' 
	Exception'' 
err''  
)''  !
{(( 
throw)) 
new)) 
	Exception)) #
())# $
$str))$ W
,))W X
err))Y \
)))\ ]
;))] ^
}** 
},, 	
public.. 
void.. 
iniciarTransaccion.. &
(..& '
)..' (
{// 	
try00 
{11 
abrirConexion22 
(22 
)22 
;22  
transaccion33 
=33 
conexion33 &
.33& '
BeginTransaction33' 7
(337 8
)338 9
;339 :
}44 
catch55 
(55 
	Exception55 
err55  
)55  !
{66 
throw77 
new77 
	Exception77 #
(77# $
$str77$ [
,77[ \
err77] `
)77` a
;77a b
}88 
}99 	
public;; 
void;; 
terminarTransaccion;; '
(;;' (
);;( )
{<< 	
try== 
{>> 
transaccion?? 
.?? 
Commit?? "
(??" #
)??# $
;??$ %
conexion@@ 
.@@ 
Close@@ 
(@@ 
)@@  
;@@  !
}AA 
catchBB 
(BB 
	ExceptionBB 
errBB  
)BB  !
{CC 
throwDD 
newDD 
	ExceptionDD #
(DD# $
$strDD$ \
,DD\ ]
errDD^ a
)DDa b
;DDb c
}EE 
}FF 	
publicHH 
voidHH 
cancelarTransaccionHH '
(HH' (
)HH( )
{II 	
tryJJ 
{KK 
transaccionLL 
.LL 
RollbackLL $
(LL$ %
)LL% &
;LL& '
conexionMM 
.MM 
CloseMM 
(MM 
)MM  
;MM  !
}NN 
catchOO 
(OO 
	ExceptionOO 
errOO  
)OO  !
{PP 
throwQQ 
newQQ 
	ExceptionQQ #
(QQ# $
$strQQ$ \
,QQ\ ]
errQQ^ a
)QQa b
;QQb c
}RR 
}SS 	
publicUU 
SqlDataReaderUU 
ejecutarConsultaUU -
(UU- .
stringUU. 4
sentenciaSQLUU5 A
)UUA B
{VV 	
tryWW 
{XX 

SqlCommandYY 

comandoSQLYY %
=YY& '
conexionYY( 0
.YY0 1
CreateCommandYY1 >
(YY> ?
)YY? @
;YY@ A
ifZZ 
(ZZ 
transaccionZZ 
!=ZZ  "
nullZZ# '
)ZZ' (

comandoSQL[[ 
.[[ 
Transaction[[ *
=[[+ ,
transaccion[[- 8
;[[8 9

comandoSQL\\ 
.\\ 
CommandText\\ &
=\\' (
sentenciaSQL\\) 5
;\\5 6

comandoSQL]] 
.]] 
CommandType]] &
=]]' (
CommandType]]) 4
.]]4 5
Text]]5 9
;]]9 :
return^^ 

comandoSQL^^ !
.^^! "
ExecuteReader^^" /
(^^/ 0
)^^0 1
;^^1 2
}__ 
catch`` 
(`` 
	Exception`` 
err``  
)``  !
{aa 
throwbb 
newbb 
	Exceptionbb #
(bb# $
$strbb$ U
,bbU V
errbbW Z
)bbZ [
;bb[ \
}cc 
}dd 	
publicff 

SqlCommandff 
obtenerComandoSQLff +
(ff+ ,
stringff, 2
sentenciaSQLff3 ?
)ff? @
{gg 	
tryhh 
{ii 

SqlCommandjj 

comandoSQLjj %
=jj& '
conexionjj( 0
.jj0 1
CreateCommandjj1 >
(jj> ?
)jj? @
;jj@ A
ifkk 
(kk 
transaccionkk 
!=kk  "
nullkk# '
)kk' (

comandoSQLll 
.ll 
Transactionll *
=ll+ ,
transaccionll- 8
;ll8 9

comandoSQLmm 
.mm 
CommandTextmm &
=mm' (
sentenciaSQLmm) 5
;mm5 6

comandoSQLnn 
.nn 
CommandTypenn &
=nn' (
CommandTypenn) 4
.nn4 5
Textnn5 9
;nn9 :
returnoo 

comandoSQLoo !
;oo! "
}pp 
catchqq 
(qq 
	Exceptionqq 
errqq  
)qq  !
{rr 
throwss 
newss 
	Exceptionss #
(ss# $
$strss$ T
,ssT U
errssV Y
)ssY Z
;ssZ [
}tt 
}uu 	
publicww 

SqlCommandww )
obtenerComandoDeProcedimientoww 7
(ww7 8
stringww8 >#
procedimientoAlmacenadoww? V
)wwV W
{xx 	
tryyy 
{zz 

SqlCommand{{ 

comandoSQL{{ %
={{& '
conexion{{( 0
.{{0 1
CreateCommand{{1 >
({{> ?
){{? @
;{{@ A
if|| 
(|| 
transaccion|| 
!=||  "
null||# '
)||' (

comandoSQL}} 
.}} 
Transaction}} *
=}}+ ,
transaccion}}- 8
;}}8 9

comandoSQL~~ 
.~~ 
CommandText~~ &
=~~' (#
procedimientoAlmacenado~~) @
;~~@ A

comandoSQL 
. 
CommandType &
=' (
CommandType) 4
.4 5
StoredProcedure5 D
;D E
return
ÄÄ 

comandoSQL
ÄÄ !
;
ÄÄ! "
}
ÅÅ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
err
ÇÇ  
)
ÇÇ  !
{
ÉÉ 
throw
ÑÑ 
new
ÑÑ 
	Exception
ÑÑ #
(
ÑÑ# $
$str
ÑÑ$ T
,
ÑÑT U
err
ÑÑV Y
)
ÑÑY Z
;
ÑÑZ [
}
ÖÖ 
}
áá 	
}
àà 
}ãã “<
iD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\ADO_SQLServer\PeriodoDePagoDAO.cs
	namespace 	
CapaPersistencia
 
. 
ADO_SQLServer (
{ 
public 

class 
PeriodoDePagoDAO !
:! "
IPeriodo" *
{ 
private 
	GestorSQL 
	gestorSQL #
;# $
public 
PeriodoDePagoDAO 
(  
IGestorAccesoADatos  3
	gestorSQL4 =
)= >
{ 	
this 
. 
	gestorSQL 
= 
( 
	GestorSQL '
)' (
	gestorSQL( 1
;1 2
} 	
public 
void 
actualizarPeriodo %
(% &
PeriodoDePago& 3
periodoDePago4 A
)A B
{ 	

SqlCommand 
comando 
; 
String 
consultaSQL 
=  
$str! b
+c d
periodoDePagoe r
.r s
CodigoPeriodo	s Ä
+
Å Ç
$str
É á
;
á à
try 
{ 
comando 
= 
	gestorSQL #
.# $
obtenerComandoSQL$ 5
(5 6
consultaSQL6 A
)A B
;B C
int 
cant 
; 
cant 
= 
comando 
. 
ExecuteNonQuery .
(. /
)/ 0
;0 1
if 
( 
cant 
== 
$num 
) 
{   
}!! 
else"" 
{## 
throw$$ 
new$$ 
	Exception$$ '
($$' (
$str$$( F
)$$F G
;$$G H
}%% 
}&& 
catch'' 
('' 
	Exception'' 
err''  
)''  !
{(( 
throw)) 
err)) 
;)) 
}** 
}++ 	
private,, 
PeriodoDePago,, 
obtenerPeriodo,, ,
(,,, -
SqlDataReader,,- :
resultadoSQL,,; G
),,G H
{-- 	
PeriodoDePago.. 
periodoDePago.. '
=..( )
new..* -
PeriodoDePago... ;
{..< =
CodigoPeriodo// 
=// 
resultadoSQL//  ,
.//, -
GetColumnValue//- ;
<//; <
int//< ?
>//? @
(//@ A
$str//A P
)//P Q
,//Q R
Estado00 
=00 
resultadoSQL00 %
.00% &
GetColumnValue00& 4
<004 5
Boolean005 <
>00< =
(00= >
$str00> F
)00F G
,00G H
FechaFin11 
=11 
resultadoSQL11 '
.11' (
GetColumnValue11( 6
<116 7
DateTime117 ?
>11? @
(11@ A
$str11A K
)11K L
,11L M
FechaInicio22 
=22 
resultadoSQL22 *
.22* +
GetColumnValue22+ 9
<229 :
DateTime22: B
>22B C
(22C D
$str22D Q
)22Q R
}33 
;33 
return44 
periodoDePago44  
;44  !
}55 	
public88 
PeriodoDePago88 
buscarPeriodo88 *
(88* +
int88+ .
codigoPeriodo88/ <
)88< =
{99 	
PeriodoDePago:: 
periodoDePago:: '
;::' (
String<< 
consultaSQL<< 
=<<  
$str	<<! û
+
<<ü †
codigoPeriodo
<<° Æ
+
<<Ø ∞
$str
<<± µ
;
<<µ ∂
try== 
{>> 
SqlDataReader?? 
resultadoSQL?? *
=??+ ,
	gestorSQL??- 6
.??6 7
ejecutarConsulta??7 G
(??G H
consultaSQL??H S
)??S T
;??T U
if@@ 
(@@ 
resultadoSQL@@  
.@@  !
Read@@! %
(@@% &
)@@& '
)@@' (
{AA 
periodoDePagoBB !
=BB" #
obtenerPeriodoBB$ 2
(BB2 3
resultadoSQLBB3 ?
)BB? @
;BB@ A
}CC 
elseDD 
{EE 
throwFF 
newFF 
	ExceptionFF '
(FF' (
$strFF( >
)FF> ?
;FF? @
}GG 
}HH 
catchII 
(II 
	ExceptionII 
errII  
)II  !
{JJ 
throwKK 
errKK 
;KK 
}LL 
returnMM 
periodoDePagoMM  
;MM  !
}NN 	
publicOO 
PeriodoDePagoOO 
buscarPeriodoActivoOO 0
(OO0 1
BooleanOO1 8
estadoOO9 ?
)OO? @
{PP 	
PeriodoDePagoQQ 
periodoDePagoQQ '
;QQ' (
StringSS 
consultaSQLSS 
=SS  
$strSS! s
+SSt u
estadoSSv |
+SS} ~
$str	SS É
;
SSÉ Ñ
tryTT 
{UU 
SqlDataReaderVV 
resultadoSQLVV *
=VV+ ,
	gestorSQLVV- 6
.VV6 7
ejecutarConsultaVV7 G
(VVG H
consultaSQLVVH S
)VVS T
;VVT U
ifWW 
(WW 
resultadoSQLWW  
.WW  !
ReadWW! %
(WW% &
)WW& '
)WW' (
{XX 
periodoDePagoYY !
=YY" #
obtenerPeriodoYY$ 2
(YY2 3
resultadoSQLYY3 ?
)YY? @
;YY@ A
}ZZ 
else[[ 
{\\ 
throw]] 
new]] 
	Exception]] '
(]]' (
$str]]( B
)]]B C
;]]C D
}^^ 
}__ 
catch`` 
(`` 
	Exception`` 
err``  
)``  !
{aa 
throwbb 
newbb 
	Exceptionbb #
(bb# $
$strbb$ >
)bb> ?
;bb? @
}cc 
returndd 
periodoDePagodd  
;dd  !
}ee 	
publicii 
PeriodoDePagoii 
buscarPeriodoFechaii /
(ii/ 0
DateTimeii0 8
fechaInicioii9 D
,iiD E
DateTimeiiF N
fechaFiniiO W
)iiW X
{jj 	
PeriodoDePagokk 
periodoDePagokk '
;kk' (
Stringmm 
consultaSQLmm 
=mm  
$str	mm! ä
+
mmã å
fechaInicio
mmç ò
+
mmô ö
$str
mmõ ª
+
mmº Ω
fechaFin
mmæ ∆
+
mm« »
$str
mm… Õ
;
mmÕ Œ
trynn 
{oo 
SqlDataReaderpp 
resultadoSQLpp *
=pp+ ,
	gestorSQLpp- 6
.pp6 7
ejecutarConsultapp7 G
(ppG H
consultaSQLppH S
)ppS T
;ppT U
ifqq 
(qq 
resultadoSQLqq  
.qq  !
Readqq! %
(qq% &
)qq& '
)qq' (
{rr 
periodoDePagoss !
=ss" #
obtenerPeriodoss$ 2
(ss2 3
resultadoSQLss3 ?
)ss? @
;ss@ A
}tt 
elseuu 
{vv 
throwww 
newww 
	Exceptionww '
(ww' (
$strww( >
)ww> ?
;ww? @
}xx 
}yy 
catchzz 
(zz 
	Exceptionzz 
errzz  
)zz  !
{{{ 
return|| 
null|| 
;|| 
}}} 
return~~ 
periodoDePago~~  
;~~  !
} 	
}
áá 
}àà ï
hD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\FabricaDatos\FabricaAbstracta.cs
	namespace 	
CapaPersistencia
 
. 
FabricaDatos '
{		 
public

 

abstract

 
class

 
FabricaAbstracta

 *
{ 
public 
static 
FabricaAbstracta &
crearInstancia' 5
(5 6
)6 7
{ 	
return 
new 
FabricaSQLServer '
(' (
)( )
;) *
} 	
public 
abstract 
IGestorAccesoADatos +"
crearGestorAccesoDatos, B
(B C
)C D
;D E
public 
abstract 
	IEmpleado !
crearEmpleado" /
(/ 0
IGestorAccesoADatos0 C
gestorAccesoADatosD V
)V W
;W X
public 
abstract 
	IContrato !
crearContrato" /
(/ 0
IGestorAccesoADatos0 C
	gestorSQLD M
,M N
	IEmpleadoO X
empleadoDAOY d
,d e
IAfpf j
afpDAOk q
)q r
;r s
public 
abstract 
IBoleta 
crearBoleta  +
(+ ,
IGestorAccesoADatos, ?
gestorAccesoADatos@ R
)R S
;S T
public 
abstract 
	IConcepto !
crearConcepto" /
(/ 0
IGestorAccesoADatos0 C
	gestorSQLD M
,M N
IPeriodoO W
periodoDePagoDAOX h
,h i
	IContratoj s
contratoDAOt 
)	 Ä
;
Ä Å
public 
abstract 
IPeriodo  
crearPeriodo! -
(- .
IGestorAccesoADatos. A
gestorAccesoADatosB T
)T U
;U V
public 
abstract 
IAfp 
creaAfp $
($ %
IGestorAccesoADatos% 8
gestorAccesoADatos9 K
)K L
;L M
}"" 
}## Ê
hD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\FabricaDatos\FabricaSQLServer.cs
	namespace		 	
CapaPersistencia		
 
.		 
FabricaDatos		 '
{

 
public 

class 
FabricaSQLServer !
:" #
FabricaAbstracta$ 4
{ 
public 
override 
IBoleta 
crearBoleta  +
(+ ,
IGestorAccesoADatos, ?
gestorAccesoADatos@ R
)R S
{ 	
return 
new 
BoletaDePagoDAO &
(& '
gestorAccesoADatos' 9
)9 :
;: ;
} 	
public 
override 
	IContrato !
crearContrato" /
(/ 0
IGestorAccesoADatos0 C
gestorAccesoADatosD V
,V W
	IEmpleadoX a
empleadoDAOb m
,m n
IAfpo s
afpDAOt z
)z {
{ 	
return 
new 
ContratoDAO "
(" #
gestorAccesoADatos# 5
,5 6
empleadoDAO6 A
,A B
afpDAOB H
)H I
;I J
} 	
public 
override 
	IEmpleado !
crearEmpleado" /
(/ 0
IGestorAccesoADatos0 C
gestorAccesoADatosD V
)V W
{ 	
return 
new 
EmpleadoDAO "
(" #
gestorAccesoADatos# 5
)5 6
;6 7
} 	
public 
override 
IGestorAccesoADatos +"
crearGestorAccesoDatos, B
(B C
)C D
{ 	
return 
new 
	GestorSQL  
(  !
)! "
;" #
}   	
public"" 
override"" 
IPeriodo""  
crearPeriodo""! -
(""- .
IGestorAccesoADatos"". A
gestorAccesoADatos""B T
)""T U
{## 	
return$$ 
new$$ 
PeriodoDePagoDAO$$ '
($$' (
gestorAccesoADatos$$( :
)$$: ;
;$$; <
}%% 	
public&& 
override&& 
	IConcepto&& !
crearConcepto&&" /
(&&/ 0
IGestorAccesoADatos&&0 C
	gestorSQL&&D M
,&&M N
IPeriodo&&O W
periodoDePagoDAO&&X h
,&&h i
	IContrato&&j s
contratoDAO&&t 
)	&& Ä
{'' 	
return(( 
new(( )
ConceptoDeIngresoDescuentoDAO(( 4
(((4 5
	gestorSQL((6 ?
,((? @
periodoDePagoDAO((B R
,((R S
contratoDAO((U `
)((` a
;((a b
})) 	
public++ 
override++ 
IAfp++ 
creaAfp++ $
(++$ %
IGestorAccesoADatos++% 8
gestorAccesoADatos++9 K
)++K L
{,, 	
return-- 
new-- 
AfpDAO-- 
(-- 
gestorAccesoADatos-- 0
)--0 1
;--1 2
}.. 	
}// 
}00 ç
bD:\Documents\UPN\SolucionNominaSoft\SolucionNominaSoft\CapaPersistencia\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str +
)+ ,
], -
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
$str -
)- .
]. /
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
]$$) *