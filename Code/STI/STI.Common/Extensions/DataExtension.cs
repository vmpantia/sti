namespace STI.Common.Extensions
{
    public static class DataExtension
    {
        public static void Transfer(this object to, object from)
        {
            if (to == null || from == null)
                return;

            var toProperties = to.GetType().GetProperties();
            var fromProperties = from.GetType().GetProperties();

            if (toProperties == null || fromProperties == null)
                return;

            foreach (var prop in fromProperties)
            {
                if (toProperties.ToList().Exists(data => data.Name == prop.Name))
                    prop.SetValue(to, prop.GetValue(from));

                continue;
            }
        }
    }
}
