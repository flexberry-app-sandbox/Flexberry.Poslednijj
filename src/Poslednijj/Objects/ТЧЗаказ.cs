﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Poslednijj
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Т ч заказ.
    /// </summary>
    // *** Start programmer edit section *** (ТЧЗаказ CustomAttributes)

    // *** End programmer edit section *** (ТЧЗаказ CustomAttributes)
    [AutoAltered()]
    [Caption("Заказ")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТЧЗаказE", new string[] {
            "Количество as \'Количество\'",
            "Цена as \'Цена\'",
            "СуммаНДС as \'Сумма НДС\'",
            "Сумма as \'Сумма\'",
            "ЭтоУслуга as \'Это услуга\'"})]
    public class ТЧЗаказ : ICSSoft.STORMNET.DataObject
    {
        
        private int fЦена;
        
        private bool fЭтоУслуга;
        
        private int fСуммаНДС;
        
        private int fКоличество;
        
        private int fСумма;
        
        private IIS.Poslednijj.Номенклатура fНоменклатура;
        
        private IIS.Poslednijj.ОтчетОЗак fОтчетОЗак;
        
        // *** Start programmer edit section *** (ТЧЗаказ CustomMembers)

        // *** End programmer edit section *** (ТЧЗаказ CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.Количество CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Количество Get start)

                // *** End programmer edit section *** (ТЧЗаказ.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (ТЧЗаказ.Количество Get end)

                // *** End programmer edit section *** (ТЧЗаказ.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Количество Set start)

                // *** End programmer edit section *** (ТЧЗаказ.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (ТЧЗаказ.Количество Set end)

                // *** End programmer edit section *** (ТЧЗаказ.Количество Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.Сумма CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.Сумма CustomAttributes)
        public virtual int Сумма
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Сумма Get start)

                // *** End programmer edit section *** (ТЧЗаказ.Сумма Get start)
                int result = this.fСумма;
                // *** Start programmer edit section *** (ТЧЗаказ.Сумма Get end)

                // *** End programmer edit section *** (ТЧЗаказ.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Сумма Set start)

                // *** End programmer edit section *** (ТЧЗаказ.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (ТЧЗаказ.Сумма Set end)

                // *** End programmer edit section *** (ТЧЗаказ.Сумма Set end)
            }
        }
        
        /// <summary>
        /// СуммаНДС.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.СуммаНДС CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.СуммаНДС CustomAttributes)
        public virtual int СуммаНДС
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.СуммаНДС Get start)

                // *** End programmer edit section *** (ТЧЗаказ.СуммаНДС Get start)
                int result = this.fСуммаНДС;
                // *** Start programmer edit section *** (ТЧЗаказ.СуммаНДС Get end)

                // *** End programmer edit section *** (ТЧЗаказ.СуммаНДС Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.СуммаНДС Set start)

                // *** End programmer edit section *** (ТЧЗаказ.СуммаНДС Set start)
                this.fСуммаНДС = value;
                // *** Start programmer edit section *** (ТЧЗаказ.СуммаНДС Set end)

                // *** End programmer edit section *** (ТЧЗаказ.СуммаНДС Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.Цена CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.Цена CustomAttributes)
        public virtual int Цена
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Цена Get start)

                // *** End programmer edit section *** (ТЧЗаказ.Цена Get start)
                int result = this.fЦена;
                // *** Start programmer edit section *** (ТЧЗаказ.Цена Get end)

                // *** End programmer edit section *** (ТЧЗаказ.Цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Цена Set start)

                // *** End programmer edit section *** (ТЧЗаказ.Цена Set start)
                this.fЦена = value;
                // *** Start programmer edit section *** (ТЧЗаказ.Цена Set end)

                // *** End programmer edit section *** (ТЧЗаказ.Цена Set end)
            }
        }
        
        /// <summary>
        /// ЭтоУслуга.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.ЭтоУслуга CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.ЭтоУслуга CustomAttributes)
        public virtual bool ЭтоУслуга
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.ЭтоУслуга Get start)

                // *** End programmer edit section *** (ТЧЗаказ.ЭтоУслуга Get start)
                bool result = this.fЭтоУслуга;
                // *** Start programmer edit section *** (ТЧЗаказ.ЭтоУслуга Get end)

                // *** End programmer edit section *** (ТЧЗаказ.ЭтоУслуга Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.ЭтоУслуга Set start)

                // *** End programmer edit section *** (ТЧЗаказ.ЭтоУслуга Set start)
                this.fЭтоУслуга = value;
                // *** Start programmer edit section *** (ТЧЗаказ.ЭтоУслуга Set end)

                // *** End programmer edit section *** (ТЧЗаказ.ЭтоУслуга Set end)
            }
        }
        
        /// <summary>
        /// Т ч заказ.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.Номенклатура CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.Номенклатура CustomAttributes)
        [PropertyStorage(new string[] {
                "Номенклатура"})]
        [NotNull()]
        public virtual IIS.Poslednijj.Номенклатура Номенклатура
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Номенклатура Get start)

                // *** End programmer edit section *** (ТЧЗаказ.Номенклатура Get start)
                IIS.Poslednijj.Номенклатура result = this.fНоменклатура;
                // *** Start programmer edit section *** (ТЧЗаказ.Номенклатура Get end)

                // *** End programmer edit section *** (ТЧЗаказ.Номенклатура Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.Номенклатура Set start)

                // *** End programmer edit section *** (ТЧЗаказ.Номенклатура Set start)
                this.fНоменклатура = value;
                // *** Start programmer edit section *** (ТЧЗаказ.Номенклатура Set end)

                // *** End programmer edit section *** (ТЧЗаказ.Номенклатура Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Poslednijj.ОтчетОЗак.
        /// </summary>
        // *** Start programmer edit section *** (ТЧЗаказ.ОтчетОЗак CustomAttributes)

        // *** End programmer edit section *** (ТЧЗаказ.ОтчетОЗак CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage("ОтчетОЗак")]
        [TypeUsage(new string[] {
                "IIS.Poslednijj.ЗаказПост",
                "IIS.Poslednijj.ОтчетОЗак"})]
        public virtual IIS.Poslednijj.ОтчетОЗак ОтчетОЗак
        {
            get
            {
                // *** Start programmer edit section *** (ТЧЗаказ.ОтчетОЗак Get start)

                // *** End programmer edit section *** (ТЧЗаказ.ОтчетОЗак Get start)
                IIS.Poslednijj.ОтчетОЗак result = this.fОтчетОЗак;
                // *** Start programmer edit section *** (ТЧЗаказ.ОтчетОЗак Get end)

                // *** End programmer edit section *** (ТЧЗаказ.ОтчетОЗак Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧЗаказ.ОтчетОЗак Set start)

                // *** End programmer edit section *** (ТЧЗаказ.ОтчетОЗак Set start)
                this.fОтчетОЗак = value;
                // *** Start programmer edit section *** (ТЧЗаказ.ОтчетОЗак Set end)

                // *** End programmer edit section *** (ТЧЗаказ.ОтчетОЗак Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТЧЗаказE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТЧЗаказE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТЧЗаказE", typeof(IIS.Poslednijj.ТЧЗаказ));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ТЧЗаказ.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТЧЗаказ CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТЧЗаказ CustomAttributes)
    public class DetailArrayOfТЧЗаказ : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Poslednijj.DetailArrayOfТЧЗаказ members)

        // *** End programmer edit section *** (IIS.Poslednijj.DetailArrayOfТЧЗаказ members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ТЧЗаказ by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ТЧЗаказ.
        /// </summary>
        public DetailArrayOfТЧЗаказ(IIS.Poslednijj.ОтчетОЗак fОтчетОЗак) : 
                base(typeof(ТЧЗаказ), ((ICSSoft.STORMNET.DataObject)(fОтчетОЗак)))
        {
        }
        
        public IIS.Poslednijj.ТЧЗаказ this[int index]
        {
            get
            {
                return ((IIS.Poslednijj.ТЧЗаказ)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Poslednijj.ТЧЗаказ dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
