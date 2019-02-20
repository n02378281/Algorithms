using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public sealed class clsSingleTon
    {
        private static clsSingleTon instance = null;

        private clsSingleTon()
        {
        }

        public static clsSingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new clsSingleTon();
                }
                return instance;
            }
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }

    public sealed class SingletonClass
    {
        private static SingletonClass instance = null;
        private static readonly object padlock = new object();

        private SingletonClass()
        {
        }

        public static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonClass();
                        }
                    }
                }
                return instance;
            }
        }
    }
    //public class UserLogic
    //{
    //    private GoogleOAuthService _authService;
    //    private IEmailService _emailService;

    //    public UserLogic(IEmailSevice emailService)
    //    {
    //        _authService = new GoogleOAuthService();
    //        _emailService = emailService;
    //    }

    //    public void Send()
    //    {
    //        _emailService.SendMail("text");
    //    }
    //}

    //UserLogic s = new UserLogic(new EmailServiceClass());
    //s.Send();

    //UserLogic s = new UserLogic(new GoogleEmail());
    //s.Send();

    //_emailService.SendMail("text");


}
