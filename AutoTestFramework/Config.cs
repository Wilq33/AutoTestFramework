namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseUrl = "http://testing.todvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfAsdfG";
                }

                public static class Password
                {
                    public static string InvalidPassword = "fdsa4321!";
                    public static string Empty = "";
                    public static string WhiteSpaces = "     ";
                }

                public static class Email
                {
                    public static string Empty = "";
                    public static string WhiteSpaces = "      ";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDot = "example@examplecom";
                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
        }
    }
}
