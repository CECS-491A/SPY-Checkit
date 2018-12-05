﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CheckIt.UserManagement
{
    public class User
    {
        public class QA
        {
            public String question { set; get; }
            public String answer { set; get; }
            public QA(String q, String a)
            {
                question = q;
                answer = a;
            }
        }

        public int userID { set; get; }
        public int clientID { set; get; }
        public int parentID { set; get; }
        public int height { set; get; }
        public String email { set; get; }
        public String accountType { set; get; }
        public Boolean firstLogin { set; get; }
        public Boolean active { set; get; }
        public List<String> actions;

        public User()
        {

        }

        public User(String email, String atype)
        {
            this.email = email;
            this.accountType = atype;
            this.firstLogin = false;
            this.active = true;

            this.userID=
            this.clientID = 1;
            this.parentID = 1;
            this.height = 1;
        }


    }
    
}