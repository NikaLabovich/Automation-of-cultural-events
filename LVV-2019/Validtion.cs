﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace LVV_2019
{
    class Validtion
    {
        public static bool TryValidateObject(object obj, TextBox loginTextBox, PasswordBox passwordBox)
        {
            bool isValidate = true;

            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(obj);

            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var error in results)
                {
                    var n = error.MemberNames;
                    foreach (var name in error.MemberNames)
                    {
                        if (name == "Login")
                        {
                            loginTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                            loginTextBox.ToolTip = new ToolTip() { Content = error };
                        }

                        if (name == "Password")
                        {
                            passwordBox.BorderBrush = new SolidColorBrush(Colors.Red);
                            passwordBox.ToolTip = new ToolTip() { Content = error };
                        }                      
                    }                    
                }
                isValidate = false;
            }
            return isValidate;
        }

        
    }
}