namespace ADCore.ADCoreCommon
{
    public class ServerDataMsg
    {
        public LoginData LoginData { get; set; }
        public  RegisterData registerData { get; set; }


    }



    public class RegisterData
    {
        public  bool IsRegister { get; set; }
    }

    public class LoginData
    {
        public  PlayerData playerData { get; set; } 
    }

    public class PlayerData
    {
        public  int IsSucessLogin { get; set; }
    }
}