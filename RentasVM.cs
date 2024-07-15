using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSPlataforma.Entities.RentasModel.ViewModel
{
    public class RentasAprobacionesResVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public List<P_TABLE> P_LIST { get; set; }
        public class P_TABLE
        {
            public string NNUMORI { get; set; }
            public string NTYPEPAGO { get; set; }
            public string DES_TYPEPAGO { get; set; }
            public string SCOD_AFP { get; set; }
            public string DES_AFP { get; set; }
            public string SCOD_BANCO { get; set; }
            public string DES_BANK { get; set; }
            public string SCOD_VIAPAGO { get; set; }
            public string DES_VIAPAGO { get; set; }
            public string SCOD_MONEDA { get; set; }
            public string DES_MONEDA { get; set; }
            public string NMTO_PENSION { get; set; }
            public string NMTO_LIQPAGAR { get; set; }
            public string NMTO_LIQSALUD { get; set; }
            public string NMTO_LIQRJUD { get; set; }
            public string CANT_REG { get; set; }
            public Boolean IS_SELECTED { get; set; }
        }
    }
    public class RentasAprobacionesDetVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public List<P_TABLE> P_LIST { get; set; }
        public class P_TABLE
        {
            public string NIDCHEQUE { get; set; }
            public string DES_NUMORI { get; set; }
            public string SNUM_POLIZA { get; set; }
            public string DES_TYPE_IDENBEN { get; set; }
            public string SNUM_IDENBEN { get; set; }
            public string SNOM_BENEFICIA { get; set; }
            public string SNOM_RECEPTOR { get; set; }
            public string DES_TYPEPAGO { get; set; }
            public string DFEC_PAGO { get; set; }
            public string DES_MONEDA { get; set; }
            public string NMTO_PENSION { get; set; }
        }
    }
    public class ResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }
    public class RentasFilterTicketsResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object GenericResponse { get; set; }
    }

    public class RentasFilterTicketResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TICKET { get; set; }
        public Object C_ADJUNTOS_REGIS { get; set; }
        public Object C_ADJUNTOS_ENVI { get; set; }
        public Object C_BENEFICIARIES { get; set; }
        public Object C_HISTORY_POL { get; set; }
        public Object C_HISTORY_STATUS { get; set; }
    }

    public class RentasTicketsVM
    {
        public string SCODE { get; set; }
        public string SCODE_JIRA { get; set; }
        public string SRAMO { get; set; }
        public string SPRODUCT { get; set; }
        public int POLIZA { get; set; }
        public string MOTIVO_DES { get; set; }
        public string SUBMOTIVO_DES { get; set; }
        public string CONTRATANTE { get; set; }
        public string ASEGURADO { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }
        public DateTime FECHA_RECEPCION { get; set; }
        public string USUARIO_REGISTRO { get; set; }
        public string SLA { get; set; }
        public string ESTADO { get; set; }
        public int? MONEDA { get; set; }
        public string IMP_DEVOLUCION { get; set; }
        public int NTYPE_SYSTEM { get; set; }
        public int NRAMO { get; set; }
        public int NPRODUCT { get; set; }
        public int NMOTIV { get; set; }
        public int NSUBMOTIV { get; set; }
        public int NTICKET { get; set; }
        public string SALERT { get; set; }
    }
    

    public class MyDataItem
    {
        public string SNAME { get; set; }
        public string SACTIVE { get; set; }
    }

    public class RentasTicketVM
    {
        public string SCODE_JIRA { get; set; }
        public string USUARIO_REGISTRO { get; set; }
        public string ESTADO { get; set; }
        public string CANAL { get; set; }
        public string FECHA_RECEPCION { get; set; }
        public string VIA_RECEPCION { get; set; }
        public string ATENCION_SLA { get; set; }
        public string FORM_CALCULO { get; set; }
        public string MOTIVO { get; set; }
        public string DET_UBIGEO { get; set; }
        public string COD_RECLAMO { get; set; }
        public string CANAL_OPERACION { get; set; }
        public string SUBMOTIVO { get; set; }
        public string IMP_DEVOLUCION { get; set; }
        public string TIPO_TRAMITE { get; set; }
        public string TIPO_PENSION { get; set; }
        public string TIPO_PRESTACION { get; set; }
        public string CANAL_INGRESO { get; set; }
        public string DESCRIPCION { get; set; }
        public string TIPO_PENSION_TCK { get; set; }
        public int NTYPE_SYSTEM { get; set; }
        public string STYPE_SYSTEM { get; set; }
        public string DOCUMENTO_CONT { get; set; }
        public string NOMBRE_CONT { get; set; }
        public string CORREO_ELECTRONICO_CONT { get; set; }
        public string NROSOL_CONTR { get; set; }
        public string POLIZA_CONTR { get; set; }
        public string CONTRATANTE { get; set; }
        public string ASESEGURADO { get; set; }
        public string NROIDENTI_ASE { get; set; }
        public string ENDOSO { get; set; }
        public string CONSULTOR_REFE { get; set; }
        public string RAMO { get; set; }
        public string PRODUCTO { get; set; }
        public string POLIZA { get; set; }
        public string ESTADO_POLIZA { get; set; }
        public string FRECUENCIA_PAGO { get; set; }
        public string PRIMA { get; set; }
        public string PERIODO_VIGENCIA { get; set; }
        public string NRO_ENDOSO { get; set; }
        public string TIPO_RENTA { get; set; }
        public string MODALIDAD { get; set; }
        public string NROS_BENEFECIER { get; set; }
        public string AFP { get; set; }
        public string TASA_CTO_REASEGURO { get; set; }
        public string TATA_CTO_EQUIVALENTE { get; set; }
        public string MONTO_PRIMA { get; set; }
        public string MESES_DIFERIDOS { get; set; }
        public string MESES_GARANTIZADOS { get; set; }
        public string SOLICITUD_DEV { get; set; }
        public string TASA_VENTA { get; set; }
        public string TASA_PERIODO_GARAN { get; set; }
        public string MONTO_PENSION { get; set; }
        public string ASESOR { get; set; }
        public string MONEDA { get; set; }
        public string MONTO { get; set; }
        public string PORC_DEVOLUCION { get; set; }
        public string INI_VIGENCIA { get; set; }
        public string FIN_VIGENCIA { get; set; }
        public string FIN_FINABONO { get; set; }
        public string FCH_DEVENGUE { get; set; }
        public string DIFERIMIENTO { get; set; }
        public string ANO_TMP { get; set; }
        public string ANO_GARANTIZA { get; set; }
        public string PENSION { get; set; }
        public string PROC_SEGURO_VIDA { get; set; }
        public string PROC_SEGURO_ACC { get; set; }
        public string PROC_AJUSTE_CAN { get; set; }
        public string GASTO_SEPELIO { get; set; }
        public string GRATIFICACION { get; set; }
        public string POLIZA_MENOR_EDAD { get; set; }
        public string FCH_RESPONSABLE { get; set; }
        public string ABSO_RESPONSABLE { get; set; }
        public string RESP_FINAL_RESPONSABLE { get; set; }
        public string RESP_SOLU_RESPONSABLE { get; set; }
        public string ATENTIDO_TICKET { get; set; }
        public string FCH_RESPUESTA_TICKET { get; set; }
        public string DIAS_ATENCION_TICKET { get; set; }
        public string SLINK_JIRA { get; set; }
        public string NTICKET { get; set; }
        public int NMOTIVO { get; set; }
        public int NSUBMOTIVO { get; set; }
    }

    public class RentasTicketBeneficiaryVM
    {
        //cursor beneficiarios
        public string NOMBRES { get; set; }
        public string NRO_IDENTIDAD { get; set; }
        public string PARENTESCO { get; set; }
        public string PROC_PENSION { get; set; }

    }

    public class RentasHistoryVM
    {
        //cursor beneficiarios
        public string INDICE { get; set; }
        public string FECHA { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO { get; set; }


    }

    public class RentasHistoryStatusVM
    {
        public string NTRANSAC { get; set; }
        public string ESTADO { get; set; }
        public string FECHA_REGISTO { get; set; }
        public string USUARIO { get; set; }
        public string STYPECOMMENT { get; set; }
        public string SCOMMETS { get; set; }
        public string INTER_DAYS { get; set; }
    }

    public class RentasADJUNTOSVM
    {
        //cursor beneficiarios
        public int NID { get; set; }
        public int NTICKET { get; set; }
        public string SCODE { get; set; }
        public string SNAME { get; set; }
        public string SSIZE { get; set; }
        public string SPATH { get; set; }
        public string SPATH_GD { get; set; }
        public int NTYPE { get; set; }

    }

    public class RentasListProductcsResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }

    public class RentasProductcsResponseVM
    {
        public int NBRANCH { get; set; }
        public int NPRODUCT { get; set; }
        public string SPRODUCT { get; set; }
    }

    public class RentasMotivosResponseVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }


    public class RentasListSubMotivosResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }

    public class RentasSubMotivosResponseVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }

    public class RentasListEstadosResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }

    public class RentasEstadoResponseVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }

    public class RentasClientsVM
    {
        public string SCLIENT { get; set; }
        public int NTYPCLIENTDOC { get; set; }
        public string STYPCLIENTDOC { get; set; }
        public string SCLINUMDOCU { get; set; }
        public string SCLIENAME { get; set; }
    }

    public class RentasASSIGNEXECResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }
    public class RentasValidaResponseVM
    {
        public int P_SVALIDA { get; set; }
    }
    public class RentasFilterDayResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public int NDAYS { get; set; }
    }
    public class RentasDayResponseVM
    {
        public int NDAYS { get; set; }
    }
    public class RentasProductCanalResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public int NPRODUCT { get; set; }
    }

    public class RentasProductCanalVM
    {
        public int NPRODUCT { get; set; }

    }
    public class RentasListActionsResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }
    public class RentasActionResponseVM
    {
        public string FECHA_INICIO { get; set; }
        public string FECHA_FIN { get; set; }
        public string PRODUCTO { get; set; }
        public string NRO_POLIZA { get; set; }
        public string MOTIVOS { get; set; }
        public string SUBMOTIVOS { get; set; }
        public string NRO_TICKET { get; set; }
        public string CUSPP { get; set; }
        public string ESTADO { get; set; }
        public string CLIENTE { get; set; }
        public string TIPO_DOC_CLIENT { get; set; }
        public string NRO_DOC_CLIENT { get; set; }
        public string BUSCAR_DOC_CLIENT { get; set; }
        public string FBUSCAR_DOC_CLIENT { get; set; }
        public string SELECCIONAR_CLIENT { get; set; }
        public string TIPO_PER_CLIENT { get; set; }
        public string NOMBRE_CLIENT { get; set; }
        public string APELLIDOP_CLIENT { get; set; }
        public string APELLIDOM_CLIENT { get; set; }
        public string RAZON_SOCIAL_CLIENT { get; set; }
        public string EDITAR_LISTADO { get; set; }
        public string ASIGNAR_EJECUTIVO { get; set; }
        public string ACCIONES { get; set; }
        public string VER_DETALLE { get; set; }
        public string ASIGNAR { get; set; }
        public string CALCULAR { get; set; }
        public string CONFIRMAR { get; set; }
        public string RECHAZAR { get; set; }
        public string DERIVAR { get; set; }
        public string OBSERVAR { get; set; }
        public string APROBAR { get; set; }
        public string CANCELAR { get; set; }
        public string BUSCAR { get; set; }
        public string REFRESCAR { get; set; }
        public string BUSCAR_POR_CLIENT { get; set; }
        public string CANCELAR_CLIENT { get; set; }
        public string CHECKBOX { get; set; }
        public string VER_JIRA { get; set; }
        public string REFRESCAR_DETALLE { get; set; }
        public string USUARIO_RESPONSABLE { get; set; }
        public string ADJUNTAR_ARCHIVO { get; set; }
        public string EDITAR_DESCRIPCION { get; set; }
        public string EDITAR_DESCRIPCION_OK { get; set; }
        public string EDITAR_DESCRIPCION_X { get; set; }
        public string DESCRIPCION_DET { get; set; }
        public string EDITAR_MOT { get; set; }
        public string EDITAR_MOT_OK { get; set; }
        public string EDITAR_MOT_X { get; set; }
        public string MOTIVO_DET { get; set; }
        public string SUBMOTIVO_DET { get; set; }
        public string ELIMINAR_ADJ { get; set; }
        public string DESCARJAR_ADJ { get; set; }
        public string SUBIR_ADJ { get; set; }
        public string CONFIRMAR_DATOS_C { get; set; }
        public string CONFIRMAR_DATOS_B { get; set; }
        public string CONFIRMAR_DATOS_H { get; set; }
        public string EDITAR_FECHA_PAGO { get; set; }
        public string EDITAR_FECHA_PAGO_OK { get; set; }
        public string EDITAR_FECHA_PAGO_X { get; set; }
        public string FECHA_PAGO_DET { get; set; }

    }

    public class RentasNidProfileResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }
    public class RentasNidProfileVM
    {
        public int NIDPROFILE { get; set; }
    }
    public class RentasListActionsTikectResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }
    public class RentasListActionsTikectVM
    {
        public string VER_DETALLE { get; set; }
        public string ASIGNAR { get; set; }
        public string CALCULAR { get; set; }
        public string CONFIRMAR { get; set; }
        public string RECHAZAR { get; set; }
        public string DERIVAR { get; set; }
        public string OBSERVAR { get; set; }
        public string APROBAR { get; set; }
        public string CANCELAR { get; set; }
    }

    public class RentasStatusTicketTikectResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }

    public class RentasGetPolicyDataResponseVM
    {
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public DateTime FECHA_EMISION { get; set; }
        public int PRIMA { get; set; }
        public int SUMA_ASEGURADA { get; set; }
        public string INVERSION { get; set; }

        public string RAMO { get; set; }
        public string PRODUCTO { get; set; }
        public string POLIZA { get; set; }
        public string ESTADO_POLIZA { get; set; }
        public string FRECUENCIA_PAGO { get; set; }
        //
        public string MONEDA { get; set; }
        public string MONTO { get; set; }
        public string DEVOLUCION { get; set; }
        //
        //
        public DateTime FIN_ABONO { get; set; }
        public string FECHA_DEVENGUE { get; set; }
        public string DIFERIMIENTO { get; set; }
        public string AÑOS_TMP { get; set; }
        public string AÑOS_GANARANTIZA { get; set; }
        public string PENSION { get; set; }
        public string SEGURO_VIDA { get; set; }
        public string SEGURO_ACCIDENTES { get; set; }
        public string AJUSTE_ANUAL { get; set; }
        public string GASTO_SEPELIO { get; set; }
        public string GRATIFICACION { get; set; }
        public string POLIZA_MENOR_EDAD { get; set; }


        public string PERIODO_VIGENCIA { get; set; }
        public string ENDOSO { get; set; }
        public string TIPO_PENSION { get; set; }
        public string TIPO_RENTA { get; set; }
        public string MODALIDAD { get; set; }
        public string N_BENEFICIARIOS_POLIZA { get; set; }
        public string AFP { get; set; }
        public string TASA_CRO_REASEGURO { get; set; }
        public string TASA_CTO_EQUIVALENTE { get; set; }
        public string MONTO_PRIMA { get; set; }
        public string MESES_DIFERIDOS { get; set; }
        public string MESES_GARANTIZADOS { get; set; }
        public string SOLICITUD_DEV { get; set; }
        public string TASA_VENTA { get; set; }
        public string TASA_INT_PERIODO_GARANTIZADO { get; set; }
        public string MONTO_PENSION { get; set; }
        public string ASESOR { get; set; }
    }
    public class RentasGetCalculationAmountResponseVM
    {
        public int IMPORTE { get; set; }
        public int MONEDA { get; set; }
    }

    public class RentasGetCalculationAmountVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }

    public class RentasListAdjResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object P_CURSOR { get; set; }
    }

    public class RentasListAdjVM
    {

        public string NID { get; set; }
        public string SNAME { get; set; }
        public string SSIZE { get; set; }
        public string SPATH { get; set; }
        public string SPATH_GD { get; set; }
        public int? NTYPEATTACHMENT { get; set; }
    }
    public class RentasUpdAttachmentVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }
    public class RentasInsDataEmailResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }
    public class RentasUploadFileResponseVM
    {
        public Int32 StatusCode { get; set; }
        public string Message { get; set; }
        public string P_SPATH { get; set; }
    }
    public class RentasUpdTicketDescriptResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }
    public class RentasUpdTicketNmotivResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
    }

    public class RentasGetUserResponsibleResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }

    public class RentasGetUserResponsibleVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }


    public class RentasGetValpopupResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }
    public class RentasGetValpopupVM
    {
        public int NPOP_UP { get; set; }
    }

    public class RentasGenericResponseVM
    {
        public int P_NCODE { get; set; }
        public string P_SMESSAGE { get; set; }
        public Object C_TABLE { get; set; }
    }

    public class RentasGetTypeCommentResponseVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }

    public class RentasGetDestinationResponseVM
    {
        public int NCODE { get; set; }
        public string SDESCRIPT { get; set; }
    }

    public class RentasGetEmailDestinationVM
    {
        public string SEMAILS { get; set; }
    }

    public class RentasGetEmailUserVM
    {
        public string SEMAIL { get; set; }
    }

    public class RentasGetConfFileVM
    {
        public string FILE_CANT_TK { get; set; }
        public string FILE_SIZE { get; set; }
        public string FILE_FORMATS { get; set; }
    }
    public class RentasGetMessageVM
    {
        public string SMESSAGE { get; set; }
    }

    public class GetRouteFile
    {
        public object SROUTE { get; set; }
    }

    public class RentasSMESSAGEResponseVM
    {
        public string SMESSAGE { get; set; }
    }

    public class RentasListTicketInterfaceVM
    {
        public int NINTERFACE { get; set; }
    }
}

