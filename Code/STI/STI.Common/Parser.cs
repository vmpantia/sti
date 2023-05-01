using STI.Common.Constants;

namespace STI.Common
{
    public class Parser
    {
        public static string ParseType(int type)
        {
            switch(type)
            {
                case Constants.Type.STD_REGULAR_INT:
                    return Constants.Type.STD_REGULAR_STRING;

                case Constants.Type.STD_IREGULAR_INT:
                    return Constants.Type.STD_IREGULAR_STRING;

                default:
                    return string.Empty;
            }
        }
        public static int ParseType(string type)
        {
            switch (type)
            {
                case Constants.Type.STD_REGULAR_STRING:
                    return Constants.Type.STD_REGULAR_INT;

                case Constants.Type.STD_IREGULAR_STRING:
                    return Constants.Type.STD_IREGULAR_INT;

                default:
                    return -1;
            }
        }
        public static string ParseStatus(int type)
        {
            switch (type)
            {
                case Status.ENABLED_INT:
                    return Status.ENABLED_STRING;
                        
                case Status.DISABLED_INT:
                    return Status.DISABLED_STRING;

                case Status.DELETION_INT:
                    return Status.DELETION_STRING;

                default:
                    return string.Empty;
            }
        }
        public static int ParseStatus(string type)
        {
            switch (type)
            {
                case Status.ENABLED_STRING:
                    return Status.ENABLED_INT;

                case Status.DISABLED_STRING:
                    return Status.DISABLED_INT;

                case Status.DELETION_STRING:
                    return Status.DELETION_INT;

                default:
                    return -1;
            }
        }
    }
}
