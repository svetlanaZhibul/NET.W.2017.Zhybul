﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution.ValidationLogicClasses;

namespace Task1.Solution
{
    public class CommonValidatorService : IValidationChecker
    {
        public Tuple<bool, string> CheckSqlFile(string psw, SqlRepository repository)
        {
            return CommonValidatorLogic.Check(psw);
        }

        public Tuple<bool, string> CheckTextFile(string psw, TextFileReporitory repository)
        {
            return CommonValidatorLogic.Check(psw);
        }
    }
}
