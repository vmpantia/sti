namespace STI.Common.Extensions
{
    public static class DataExtension
    {
        public static void Transfer(this object to, object from)
        {
            if (to == null || from == null)
                return;

            var fromProperties = from.GetType().GetProperties();
            foreach (var prop in fromProperties)
            {
                var property = to.GetType().GetProperty(prop.Name);
                if(property != null)
                    property.SetValue(to, prop.GetValue(from));

                continue;
            }
        }
    }
}
