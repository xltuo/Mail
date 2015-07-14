﻿using System.Net.Mail;
using Mafly.Mail;

namespace Mail.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mailService = new Mafly.Mail.Mail();

            mailService.Send("mafly@obo2o.cn", "测试邮件发送！");

            mailService.Send("mafly@obo2o.cn", "mafly", "测试邮件发送！");

            mailService.Send("mafly@obo2o.cn", "mafly", "邮件发送", "测试邮件发送！");

            mailService.Send(new MailInfo
            {
                Receiver = "mafly@obo2o.cn",
                ReceiverName = "mafly",
                Subject = "邮件发送",
                Body = "测试邮件发送！"
            });

            mailService.Send(
                new MailInfo
                {
                    Receiver = "mafly@obo2o.cn",
                    ReceiverName = "mafly",
                    Subject = "带附件邮件发送",
                    Body = "测试带附件邮件发送！"
                }, "../../Program.cs");

            mailService.Send(
                new MailInfo
                {
                    Receiver = "mafly@obo2o.cn",
                    ReceiverName = "mafly",
                    Subject = "带附件邮件发送",
                    Body = "测试带附件邮件发送！"
                }, new Attachment("../../Program.cs"), new Attachment("../../App.config"));

            System.Console.ReadKey();
        }
    }
}