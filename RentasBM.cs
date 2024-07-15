using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSPlataforma.Entities.RentasModel.BindingModel
{
    public class RentasAprobacionesResBM
    {
        public int P_NNUMORI { get; set; }
        public int P_NTYPEOP { get; set; }
        public DateTime P_DFECINI { get; set; }
        public DateTime P_DFECFIN { get; set; }
    }
    public class RentasAprobacionesDetBM
    {
        public string P_SKEY { get; set; }
        public int P_NNUMORI { get; set; }
        public int P_NTYPEOP { get; set; }
        public string P_SCOD_AFP { get; set; }
        public string P_SCOD_BANCO { get; set; }
        public string P_SCOD_VIAPAGO { get; set; }
        public string P_SCOD_MONEDA { get; set; }
        public DateTime P_DFECINI { get; set; }
        public DateTime P_DFECFIN { get; set; }
        public string P_SUSR_APROB { get; set; }
    }
    public class RentasAprobarPagosBM
    {
        public List<RentasAprobacionesDetBM> P_LIST { get; set; }
    }
    public class ReportRentasResBM
    {
        public int P_NNUMORI { get; set; }
        public int P_NTYPEOP { get; set; }
        public DateTime P_DFECINI { get; set; }
        public DateTime P_DFECFIN { get; set; }
    }
    public class ReportRentasDetBM
    {
        public int P_NNUMORI { get; set; }
        public int P_NTYPEOP { get; set; }
        public string P_SCOD_AFP { get; set; }
        public string P_SCOD_BANCO { get; set; }
        public string P_SCOD_VIAPAGO { get; set; }
        public string P_SCOD_MONEDA { get; set; }
        public DateTime P_DFECINI { get; set; }
        public DateTime P_DFECFIN { get; set; }
        public string P_SUSR_APROB { get; set; }
    }

    public class ModuleReportsRentasFilter
    {
        public int P_NNUMORI { get; set; }
        public int P_NTYPEOP { get; set; }
        public int P_NREPORT { get; set; }
        public int P_NTIPO { get; set; }
    }

    public class RentasFilterTicketsBM
    {
        public DateTime P_DATEINI { get; set; }
        public DateTime P_DATEEND { get; set; }
        public int P_NBRANCH { get; set; }
        public int P_NPRODUCT { get; set; }
        public int P_NPOLICY { get; set; }
        public int P_NMOTIVO { get; set; }
        public int P_SSUBMOTIVO { get; set; }
        public string P_SCODE_JIRA { get; set; }
        public string P_SCUSPP { get; set; }
        public int P_NSTATE { get; set; }
        public string P_SCLIENT { get; set; }
        public int P_NUSERCODE { get; set; }
        public int P_NUSERCODE_RE { get; set; }
        public string P_SUSUARIO_RESPONSABLE { get; set; }

    }
    
    public class RentasFilterTicketBM
    {
        public string P_SCODE { get; set; }
        public int P_NUSERCODE { get; set; }
    }
    public class RentasASSIGNEXECBM
    {
        public string P_SCODE_JIRA { get; set; }
        public int P_NUSERCODE_RE { get; set; }
        public int P_NUSERCODE { get; set; }
        public List<string> LIST_SCODE_JIRA { get; set; }
    }
    public class RentasListProductcsBM
    {
        public string P_NPRODUCT { get; set; }
    }

    public class RentasSubMotivoscsBM
    {
        public string P_NMOTIVO { get; set; }
    }
    public class RentasClientsBM
    {
        public int P_NTIPO_BUSQUEDA { get; set; }
        public int P_NTIPO_DOC { get; set; }
        public string P_NNUM_DOC { get; set; }
        public string P_SNOMBRE { get; set; }
        public string P_SAP_PATERNO { get; set; }
        public string P_SAP_MATERNO { get; set; }
        public string P_SNOMBRE_LEGAL { get; set; }
    }
    public class RentasValidaBM
    {
        public int P_NTYPCLIENTDOC { get; set; }
        public string P_SCLINUMDOCU { get; set; }
    }
    public class RentasFilterDayBM
    {
        public DateTime P_DDAYEND { get; set; }
    }
    public class RentasListActionsBM
    {
        public int P_NPRODUCT { get; set; }
        public int P_NIDPROFILE { get; set; }
    }
    public class RentasNidProfileBM
    {
        public int P_NIDUSER { get; set; }
        public int P_NPRODUCT { get; set; }
    }
    public class RentasListActionsTikectBM
    {
        public string P_SCODE { get; set; }
        public int P_NUSERCODE { get; set; }
        public int P_NPRODUCT { get; set; }
        public int P_NIDPROFILE { get; set; }
    }

    public class RentaseEjecutivosBM
    {
        public int P_NUSERCODE { get; set; }
        public int P_NIDPROFILE { get; set; }
    }

    public class RentasStatusTicketTikectBM
    {
        public string P_SCODE_JIRA { get; set; }
        public int P_NUSERCODE { get; set; }
        public int P_NIDPROFILE { get; set; }
        public string P_SNAME_ACT { get; set; }
        public int P_NTYPECOMMENT { get; set; }
        public string P_SCOMMETS { get; set; }
    }
    public class RentasGetPolicyDataBM
    {
        public int NTYPE_SYSTEM { get; set; }
        public int P_NRAMO { get; set; }
        public int P_NPRODUCTO { get; set; }
        public int P_NPOLIZA { get; set; }
        public string P_SCLINUMDOCU { get; set; }
 
    }
    public class RentasGetCalculationAmountBM
    {
        public int NTYPE_SYSTEM { get; set; }
        public int P_NRAMO { get; set; }
        public int P_NPRODUCT { get; set; }
        public int P_NMOTIVO { get; set; }
        public int P_NSUBMOTIVO { get; set; }
        public int P_NPOLIZA { get; set; }
        public int P_NTIPO_DOC { get; set; }
        public int P_NNUM_DOC { get; set; }
        public int P_NERRORNUM { get; set; }
    }
    
    public class RentasUpdAmountTicketBM
    {
        public int P_NTICKET { get; set; }
        public int P_IMPORTE { get; set; }
        public int P_MONEDA { get; set; }  
    }

    public class RentasListAdjBM
    {
        public int P_NTICKET { get; set; }
    }
    public class RentasUpdAttachmentBM
    {
        public int P_NTICKET { get; set; }
        public int P_NTYPEATTACHMENT { get; set; }
        public int P_NID { get; set; }
    }
    public class RentasInsDataEmailBM
    {
        public int P_NTICKET { get; set; }
        public string P_SEMAIL_MESSAGE { get; set; }
        public string P_SEMAIL_SUBJECT { get; set; }
        public string P_SMASK_EMAIL { get; set; }
        public string P_SRECIPIENT_EMAIL { get; set; }
        public int P_NBRANCH { get; set; }
        public int P_NPRODUCT { get; set; }
        public int P_NMOTIV { get; set; }
        public int P_NSUBMOTIV { get; set; }
        public int P_NPOLICY { get; set; }
        public int P_NUSERCODE { get; set; }
        public int P_NCOMMUNICATION_TYPE { get; set; }
    }

    public class RentasInsTickAdjuntBM
    {
        public string P_SCODE { get; set; }
        public int P_NTICKET { get; set; }
        public string P_SNAME { get; set; }
        public string P_SSIZE { get; set; }
        public string P_SPATH { get; set; }
        public int P_NUSERCODE { get; set; }
    }

    public class RentasDelTickAdjuntBM
    {
        public int P_NID { get; set; }
    }
    public class RentasUpdTicketDescriptBM
    {
        public int P_NTICKET { get; set; }
        public string P_SDESCRIPT { get; set; }
    }
    public class RentasUpdTicketNmotivBM
    {
        public int P_NTICKET { get; set; }
        public int P_NMOTIV { get; set; }
        public int P_NSUBMOTIV { get; set; }
    }
    public class RentasGetUserResponsibleBM
    {
        public int P_NUSERCODE { get; set; }
    }
    public class RentasGetValpopupBM
    {
        public int P_NTICKET { get; set; }
        public string P_SNAME_ACT { get; set; }
        public int P_NIDPROFILE { get; set; }
    }
    public class RentasGetEmailDestinationBM
    {
        public string P_STYPE_DEST { get; set; }
        public int P_NTICKET { get; set; }
    }
    public class RentasGetEmailUserBM
    {
        public int P_NUSERCODE { get; set; }
    }
    public class RentasGetMessage
    {
        public int P_NERRORNUM { get; set; }
    }
    public class RentasListTicketInterfaceBM
    {
        public int P_NTICKET { get; set; }
    }
}

