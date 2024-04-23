
namespace Ixm.Nexus.Commons
{
    public static class Constants
    {
        public struct Core
        {
            public struct AccessLevel
            {
                public const string INTERNO = "Interno";
                public const string EXTERNO = "Externo";
            }

            public struct Audit
            {
                public const string CREATION_USER = "CreationUser";
                public const string CREATION_DATE = "CreationDate";
                public const string MODIFICATION_USER = "ModificationUser";
                public const string MODIFICATION_DATE = "ModificationDate";
                public const string ROW_STATUS = "RowStatus";
                public const string SYSTEM = "System";
            }


            public struct UserClaims
            {
                public const string UserId = "UserId";
                public const string UserName = "UserName";
                public const string Role = "Role";
                public const string FullName = "FullName";
                public const string Society = "Society";
                public const string ServiceOrganization = "ServiceOrganization";
            }

            public struct UserStatus
            {
                public const string ACTIVE = "A";
            }

            public struct DateTimeFormats
            {
                public const string DD_MM_YYYY_HH_MM_SS_FFF = "yyyyMMddHHmmssFFF";
            }

            public static class Token
            {
                public const string TOKEN_STATUS = "TETK";

                public const string CURRENT_USER = "CurrentUser";
                public const string ACCESS_LEVEL = "AccessLevel";
                public const string ROLES_INTERNO = "RolesInterno";

                public struct Estados
                {
                    public const string ACTIVE = "ETKA";
                    public const string CANCEL = "ETKC";
                    public const string COMPLETE = "ETKS";
                    public const string EXPIRE = "ETKX";
                }

                public struct Motive
                {
                    public const string AUTENTICATION = "MTKA";
                    public const string RECOVERY_PASSWORD = "MTKX";
                    public const string INVITATION_CONTACT = "MTKC";
                }

                public struct Vigency
                {
                    public const string VIGENCIA_AUTENTICACION = "VTKA";
                    public const string VIGENCIA_RECUPERAR_CONTRASENA = "VTKX";
                    public const string VIGENCIA_INVITACION_CONTACTO = "VTKC";
                }
            }

        }

        public static class Seguridad
        {
            public struct TypeUser
            {
                public const string CLIENT = "C";
                public const string ASESOR = "A";
            }

            public struct RolInternal
            {
              
            }
        }

        public static class StatusMonth
        {
           
        }

        public static class MonthDescription
        {
            public static string GetMonthDescription(string numberMonth)
            {
                switch (numberMonth)
                {
                    case "01":
                        return "Enero";

                    case "02":
                        return "Febrero";

                    case "03":
                        return "Marzo";

                    case "04":
                        return "Abril";

                    case "05":
                        return "Mayo";

                    case "06":
                        return "Junio";

                    case "07":
                        return "Julio";

                    case "08":
                        return "Agosto";

                    case "09":
                        return "Septiembre";

                    case "10":
                        return "Octubre";

                    case "11":
                        return "Noviembre";

                    case "12":
                        return "Diciembre";

                    default:
                        return "NO RELEVANTE";
                }
            }
        }

        public struct Common
        {

            public struct Messages
            {


                public struct Security
                {
                    public const string UserInactive = "No se encontró entrada";
                    public const string ContrasenTamanioMinimo = "HPDAA0284E";
                    public const string ContrasenCaracteresEspeciales = "HPDAA0285E";

                    public const string ErrorValidatingMail = "Unregistered email";
                    public const string IncorrectPassword = "Incorrect password";
                }
            }

            public struct StatusResponse
            {
                public const int FUNCTIONAL_ERROR = 1;
                public const int OK = 200;
                public const int TECNICAL_ERROR = -1;

                public struct MenuExterno
                {
                    public const int ESTADO_ACCESOS = 2;
                }
            }

            public struct RegexValidation
            {
                public const string PasswordForte = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[.,?!@+*\\-_\\$])[A-Za-z0-9.,?!@+*\\-_\\$]+$";
                public const string AnyNumber = @"^[0-9]*$";
                public const string AnyLetter = @"^[a-zA-Z\u00C0-\u00FF ]*$";
                public const string SoloLetrasRazonSocial = @"^[a-zA-Z\u00C0-\u00FF.\\-_ ]*$";
            }

            public struct Currency
            {
                public const string USD = "$";
                public const string PEN = "S/";
            }

        }

        public static class EstadoRespuesta {
            public const int ERROR_FUNCIONAL = 1;
            public const int ERROR_TECNICO = 2;
            public const int OK = 0;
        }
    }
    
}
