﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Proektirovanie_
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Поставщик.
    /// </summary>
    // *** Start programmer edit section *** (Поставщик CustomAttributes)

    // *** End programmer edit section *** (Поставщик CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПоставщикE", new string[] {
            "ФИО as \'ФИО\'",
            "Регион as \'Регион\'",
            "Адрес as \'Адрес\'",
            "ИНН as \'ИНН\'"})]
    [View("ПоставщикL", new string[] {
            "ФИО as \'ФИО\'",
            "Регион as \'Регион\'",
            "Адрес as \'Адрес\'",
            "ИНН as \'ИНН\'"})]
    public class Поставщик : ICSSoft.STORMNET.DataObject
    {
        
        private string fФИО;
        
        private string fРегион;
        
        private string fАдрес;
        
        private string fИНН;
        
        // *** Start programmer edit section *** (Поставщик CustomMembers)

        // *** End programmer edit section *** (Поставщик CustomMembers)

        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Поставщик.Адрес CustomAttributes)

        // *** End programmer edit section *** (Поставщик.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Поставщик.Адрес Get start)

                // *** End programmer edit section *** (Поставщик.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Поставщик.Адрес Get end)

                // *** End programmer edit section *** (Поставщик.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Поставщик.Адрес Set start)

                // *** End programmer edit section *** (Поставщик.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Поставщик.Адрес Set end)

                // *** End programmer edit section *** (Поставщик.Адрес Set end)
            }
        }
        
        /// <summary>
        /// ИНН.
        /// </summary>
        // *** Start programmer edit section *** (Поставщик.ИНН CustomAttributes)

        // *** End programmer edit section *** (Поставщик.ИНН CustomAttributes)
        [StrLen(255)]
        public virtual string ИНН
        {
            get
            {
                // *** Start programmer edit section *** (Поставщик.ИНН Get start)

                // *** End programmer edit section *** (Поставщик.ИНН Get start)
                string result = this.fИНН;
                // *** Start programmer edit section *** (Поставщик.ИНН Get end)

                // *** End programmer edit section *** (Поставщик.ИНН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Поставщик.ИНН Set start)

                // *** End programmer edit section *** (Поставщик.ИНН Set start)
                this.fИНН = value;
                // *** Start programmer edit section *** (Поставщик.ИНН Set end)

                // *** End programmer edit section *** (Поставщик.ИНН Set end)
            }
        }
        
        /// <summary>
        /// Регион.
        /// </summary>
        // *** Start programmer edit section *** (Поставщик.Регион CustomAttributes)

        // *** End programmer edit section *** (Поставщик.Регион CustomAttributes)
        [StrLen(255)]
        public virtual string Регион
        {
            get
            {
                // *** Start programmer edit section *** (Поставщик.Регион Get start)

                // *** End programmer edit section *** (Поставщик.Регион Get start)
                string result = this.fРегион;
                // *** Start programmer edit section *** (Поставщик.Регион Get end)

                // *** End programmer edit section *** (Поставщик.Регион Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Поставщик.Регион Set start)

                // *** End programmer edit section *** (Поставщик.Регион Set start)
                this.fРегион = value;
                // *** Start programmer edit section *** (Поставщик.Регион Set end)

                // *** End programmer edit section *** (Поставщик.Регион Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Поставщик.ФИО CustomAttributes)

        // *** End programmer edit section *** (Поставщик.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Поставщик.ФИО Get start)

                // *** End programmer edit section *** (Поставщик.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Поставщик.ФИО Get end)

                // *** End programmer edit section *** (Поставщик.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Поставщик.ФИО Set start)

                // *** End programmer edit section *** (Поставщик.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Поставщик.ФИО Set end)

                // *** End programmer edit section *** (Поставщик.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПоставщикE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПоставщикE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПоставщикE", typeof(IIS.Proektirovanie_.Поставщик));
                }
            }
            
            /// <summary>
            /// "ПоставщикL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПоставщикL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПоставщикL", typeof(IIS.Proektirovanie_.Поставщик));
                }
            }
        }
    }
}
