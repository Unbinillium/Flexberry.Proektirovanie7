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
    /// Запас материалов.
    /// </summary>
    // *** Start programmer edit section *** (ЗапасМатериалов CustomAttributes)

    // *** End programmer edit section *** (ЗапасМатериалов CustomAttributes)
    [AutoAltered()]
    [Caption("Запас материалов")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗапасМатериаловE", new string[] {
            "Товар as \'Товар\'",
            "КолВо as \'Кол во\'"})]
    public class ЗапасМатериалов : ICSSoft.STORMNET.DataObject
    {
        
        private string fТовар;
        
        private string fКолВо;
        
        private IIS.Proektirovanie_.Номенклатура fНоменклатура;
        
        // *** Start programmer edit section *** (ЗапасМатериалов CustomMembers)

        // *** End programmer edit section *** (ЗапасМатериалов CustomMembers)

        
        /// <summary>
        /// КолВо.
        /// </summary>
        // *** Start programmer edit section *** (ЗапасМатериалов.КолВо CustomAttributes)

        // *** End programmer edit section *** (ЗапасМатериалов.КолВо CustomAttributes)
        [StrLen(255)]
        public virtual string КолВо
        {
            get
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.КолВо Get start)

                // *** End programmer edit section *** (ЗапасМатериалов.КолВо Get start)
                string result = this.fКолВо;
                // *** Start programmer edit section *** (ЗапасМатериалов.КолВо Get end)

                // *** End programmer edit section *** (ЗапасМатериалов.КолВо Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.КолВо Set start)

                // *** End programmer edit section *** (ЗапасМатериалов.КолВо Set start)
                this.fКолВо = value;
                // *** Start programmer edit section *** (ЗапасМатериалов.КолВо Set end)

                // *** End programmer edit section *** (ЗапасМатериалов.КолВо Set end)
            }
        }
        
        /// <summary>
        /// Товар.
        /// </summary>
        // *** Start programmer edit section *** (ЗапасМатериалов.Товар CustomAttributes)

        // *** End programmer edit section *** (ЗапасМатериалов.Товар CustomAttributes)
        [StrLen(255)]
        public virtual string Товар
        {
            get
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.Товар Get start)

                // *** End programmer edit section *** (ЗапасМатериалов.Товар Get start)
                string result = this.fТовар;
                // *** Start programmer edit section *** (ЗапасМатериалов.Товар Get end)

                // *** End programmer edit section *** (ЗапасМатериалов.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.Товар Set start)

                // *** End programmer edit section *** (ЗапасМатериалов.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (ЗапасМатериалов.Товар Set end)

                // *** End programmer edit section *** (ЗапасМатериалов.Товар Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Proektirovanie_.Номенклатура.
        /// </summary>
        // *** Start programmer edit section *** (ЗапасМатериалов.Номенклатура CustomAttributes)

        // *** End programmer edit section *** (ЗапасМатериалов.Номенклатура CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Номенклатура"})]
        public virtual IIS.Proektirovanie_.Номенклатура Номенклатура
        {
            get
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.Номенклатура Get start)

                // *** End programmer edit section *** (ЗапасМатериалов.Номенклатура Get start)
                IIS.Proektirovanie_.Номенклатура result = this.fНоменклатура;
                // *** Start programmer edit section *** (ЗапасМатериалов.Номенклатура Get end)

                // *** End programmer edit section *** (ЗапасМатериалов.Номенклатура Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗапасМатериалов.Номенклатура Set start)

                // *** End programmer edit section *** (ЗапасМатериалов.Номенклатура Set start)
                this.fНоменклатура = value;
                // *** Start programmer edit section *** (ЗапасМатериалов.Номенклатура Set end)

                // *** End programmer edit section *** (ЗапасМатериалов.Номенклатура Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗапасМатериаловE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗапасМатериаловE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗапасМатериаловE", typeof(IIS.Proektirovanie_.ЗапасМатериалов));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ЗапасМатериалов.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfЗапасМатериалов CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfЗапасМатериалов CustomAttributes)
    public class DetailArrayOfЗапасМатериалов : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Proektirovanie_.DetailArrayOfЗапасМатериалов members)

        // *** End programmer edit section *** (IIS.Proektirovanie_.DetailArrayOfЗапасМатериалов members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ЗапасМатериалов by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ЗапасМатериалов.
        /// </summary>
        public DetailArrayOfЗапасМатериалов(IIS.Proektirovanie_.Номенклатура fНоменклатура) : 
                base(typeof(ЗапасМатериалов), ((ICSSoft.STORMNET.DataObject)(fНоменклатура)))
        {
        }
        
        public IIS.Proektirovanie_.ЗапасМатериалов this[int index]
        {
            get
            {
                return ((IIS.Proektirovanie_.ЗапасМатериалов)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Proektirovanie_.ЗапасМатериалов dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
