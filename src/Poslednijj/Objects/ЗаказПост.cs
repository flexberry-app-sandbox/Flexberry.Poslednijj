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
    /// Заказ пост.
    /// </summary>
    // *** Start programmer edit section *** (ЗаказПост CustomAttributes)

    // *** End programmer edit section *** (ЗаказПост CustomAttributes)
    [AutoAltered()]
    [Caption("Заказ поставщику")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказПостE", new string[] {
            "Номер as \'Номер\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаОкончания as \'Дата окончания\'",
            "СостояниеОплаты as \'Состояние оплаты\'",
            "СостОтгрузки as \'Сост отгрузки\'",
            "СуммаВклНДС as \'Сумма вкл НДС\'",
            "СуммаДокумента as \'Сумма документа\'",
            "Контрагенты",
            "Контрагенты.Контрагент",
            "Организации",
            "Организации.Организация",
            "Склады",
            "Склады.Склад"})]
    [AssociatedDetailViewAttribute("ЗаказПостE", "Заказ", "ТЧЗаказE", true, "", "Заказ", true, new string[] {
            ""})]
    [View("ЗаказПостL", new string[] {
            "СостояниеОплаты as \'Состояние оплаты\'",
            "СостОтгрузки as \'Сост отгрузки\'",
            "СуммаВклНДС as \'Сумма вкл НДС\'",
            "СуммаДокумента as \'Сумма документа\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаОкончания as \'Дата окончания\'",
            "Номер as \'Номер\'",
            "Организации",
            "Склады"})]
    public class ЗаказПост : IIS.Poslednijj.ОтчетОЗак
    {
        
        private IIS.Poslednijj.DetailArrayOfТЧЗаказ fЗаказ;
        
        // *** Start programmer edit section *** (ЗаказПост CustomMembers)

        // *** End programmer edit section *** (ЗаказПост CustomMembers)

        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.ДатаНачала CustomAttributes)
        public override System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.ДатаНачала Get start)

                // *** End programmer edit section *** (ЗаказПост.ДатаНачала Get start)
                System.DateTime result = base.ДатаНачала;
                // *** Start programmer edit section *** (ЗаказПост.ДатаНачала Get end)

                // *** End programmer edit section *** (ЗаказПост.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.ДатаНачала Set start)

                // *** End programmer edit section *** (ЗаказПост.ДатаНачала Set start)
                base.ДатаНачала = value;
                // *** Start programmer edit section *** (ЗаказПост.ДатаНачала Set end)

                // *** End programmer edit section *** (ЗаказПост.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ДатаОкончания.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.ДатаОкончания CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.ДатаОкончания CustomAttributes)
        public override System.DateTime ДатаОкончания
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.ДатаОкончания Get start)

                // *** End programmer edit section *** (ЗаказПост.ДатаОкончания Get start)
                System.DateTime result = base.ДатаОкончания;
                // *** Start programmer edit section *** (ЗаказПост.ДатаОкончания Get end)

                // *** End programmer edit section *** (ЗаказПост.ДатаОкончания Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.ДатаОкончания Set start)

                // *** End programmer edit section *** (ЗаказПост.ДатаОкончания Set start)
                base.ДатаОкончания = value;
                // *** Start programmer edit section *** (ЗаказПост.ДатаОкончания Set end)

                // *** End programmer edit section *** (ЗаказПост.ДатаОкончания Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.Номер CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.Номер CustomAttributes)
        public override int Номер
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.Номер Get start)

                // *** End programmer edit section *** (ЗаказПост.Номер Get start)
                int result = base.Номер;
                // *** Start programmer edit section *** (ЗаказПост.Номер Get end)

                // *** End programmer edit section *** (ЗаказПост.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.Номер Set start)

                // *** End programmer edit section *** (ЗаказПост.Номер Set start)
                base.Номер = value;
                // *** Start programmer edit section *** (ЗаказПост.Номер Set end)

                // *** End programmer edit section *** (ЗаказПост.Номер Set end)
            }
        }
        
        /// <summary>
        /// СостОтгрузки.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.СостОтгрузки CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.СостОтгрузки CustomAttributes)
        public override IIS.Poslednijj.СостПоставок СостОтгрузки
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.СостОтгрузки Get start)

                // *** End programmer edit section *** (ЗаказПост.СостОтгрузки Get start)
                IIS.Poslednijj.СостПоставок result = base.СостОтгрузки;
                // *** Start programmer edit section *** (ЗаказПост.СостОтгрузки Get end)

                // *** End programmer edit section *** (ЗаказПост.СостОтгрузки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.СостОтгрузки Set start)

                // *** End programmer edit section *** (ЗаказПост.СостОтгрузки Set start)
                base.СостОтгрузки = value;
                // *** Start programmer edit section *** (ЗаказПост.СостОтгрузки Set end)

                // *** End programmer edit section *** (ЗаказПост.СостОтгрузки Set end)
            }
        }
        
        /// <summary>
        /// СостояниеОплаты.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.СостояниеОплаты CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.СостояниеОплаты CustomAttributes)
        public override IIS.Poslednijj.СостОплаты СостояниеОплаты
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.СостояниеОплаты Get start)

                // *** End programmer edit section *** (ЗаказПост.СостояниеОплаты Get start)
                IIS.Poslednijj.СостОплаты result = base.СостояниеОплаты;
                // *** Start programmer edit section *** (ЗаказПост.СостояниеОплаты Get end)

                // *** End programmer edit section *** (ЗаказПост.СостояниеОплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.СостояниеОплаты Set start)

                // *** End programmer edit section *** (ЗаказПост.СостояниеОплаты Set start)
                base.СостояниеОплаты = value;
                // *** Start programmer edit section *** (ЗаказПост.СостояниеОплаты Set end)

                // *** End programmer edit section *** (ЗаказПост.СостояниеОплаты Set end)
            }
        }
        
        /// <summary>
        /// СуммаВклНДС.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.СуммаВклНДС CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.СуммаВклНДС CustomAttributes)
        public override bool СуммаВклНДС
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.СуммаВклНДС Get start)

                // *** End programmer edit section *** (ЗаказПост.СуммаВклНДС Get start)
                bool result = base.СуммаВклНДС;
                // *** Start programmer edit section *** (ЗаказПост.СуммаВклНДС Get end)

                // *** End programmer edit section *** (ЗаказПост.СуммаВклНДС Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.СуммаВклНДС Set start)

                // *** End programmer edit section *** (ЗаказПост.СуммаВклНДС Set start)
                base.СуммаВклНДС = value;
                // *** Start programmer edit section *** (ЗаказПост.СуммаВклНДС Set end)

                // *** End programmer edit section *** (ЗаказПост.СуммаВклНДС Set end)
            }
        }
        
        /// <summary>
        /// СуммаДокумента.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.СуммаДокумента CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.СуммаДокумента CustomAttributes)
        public override int СуммаДокумента
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.СуммаДокумента Get start)

                // *** End programmer edit section *** (ЗаказПост.СуммаДокумента Get start)
                int result = base.СуммаДокумента;
                // *** Start programmer edit section *** (ЗаказПост.СуммаДокумента Get end)

                // *** End programmer edit section *** (ЗаказПост.СуммаДокумента Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.СуммаДокумента Set start)

                // *** End programmer edit section *** (ЗаказПост.СуммаДокумента Set start)
                base.СуммаДокумента = value;
                // *** Start programmer edit section *** (ЗаказПост.СуммаДокумента Set end)

                // *** End programmer edit section *** (ЗаказПост.СуммаДокумента Set end)
            }
        }
        
        /// <summary>
        /// Заказ пост.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.Контрагенты CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.Контрагенты CustomAttributes)
        [TypeUsage(typeof(IIS.Poslednijj.Контрагенты))]
        [PropertyStorage(new string[] {
                "Контрагенты"})]
        public override IIS.Poslednijj.Контрагенты Контрагенты
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.Контрагенты Get start)

                // *** End programmer edit section *** (ЗаказПост.Контрагенты Get start)
                IIS.Poslednijj.Контрагенты result = ((IIS.Poslednijj.Контрагенты)(base.Контрагенты));
                // *** Start programmer edit section *** (ЗаказПост.Контрагенты Get end)

                // *** End programmer edit section *** (ЗаказПост.Контрагенты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.Контрагенты Set start)

                // *** End programmer edit section *** (ЗаказПост.Контрагенты Set start)
                base.Контрагенты = ((IIS.Poslednijj.Контрагенты)(value));
                // *** Start programmer edit section *** (ЗаказПост.Контрагенты Set end)

                // *** End programmer edit section *** (ЗаказПост.Контрагенты Set end)
            }
        }
        
        /// <summary>
        /// Заказ пост.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.Организации CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.Организации CustomAttributes)
        [TypeUsage(typeof(IIS.Poslednijj.Организации))]
        [PropertyStorage(new string[] {
                "Организации"})]
        public override IIS.Poslednijj.Организации Организации
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.Организации Get start)

                // *** End programmer edit section *** (ЗаказПост.Организации Get start)
                IIS.Poslednijj.Организации result = ((IIS.Poslednijj.Организации)(base.Организации));
                // *** Start programmer edit section *** (ЗаказПост.Организации Get end)

                // *** End programmer edit section *** (ЗаказПост.Организации Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.Организации Set start)

                // *** End programmer edit section *** (ЗаказПост.Организации Set start)
                base.Организации = ((IIS.Poslednijj.Организации)(value));
                // *** Start programmer edit section *** (ЗаказПост.Организации Set end)

                // *** End programmer edit section *** (ЗаказПост.Организации Set end)
            }
        }
        
        /// <summary>
        /// Заказ пост.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.Склады CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.Склады CustomAttributes)
        [TypeUsage(typeof(IIS.Poslednijj.Склады))]
        [PropertyStorage(new string[] {
                "Склады"})]
        public override IIS.Poslednijj.Склады Склады
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.Склады Get start)

                // *** End programmer edit section *** (ЗаказПост.Склады Get start)
                IIS.Poslednijj.Склады result = ((IIS.Poslednijj.Склады)(base.Склады));
                // *** Start programmer edit section *** (ЗаказПост.Склады Get end)

                // *** End programmer edit section *** (ЗаказПост.Склады Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.Склады Set start)

                // *** End programmer edit section *** (ЗаказПост.Склады Set start)
                base.Склады = ((IIS.Poslednijj.Склады)(value));
                // *** Start programmer edit section *** (ЗаказПост.Склады Set end)

                // *** End programmer edit section *** (ЗаказПост.Склады Set end)
            }
        }
        
        /// <summary>
        /// Заказ пост.
        /// </summary>
        // *** Start programmer edit section *** (ЗаказПост.Заказ CustomAttributes)

        // *** End programmer edit section *** (ЗаказПост.Заказ CustomAttributes)
        public virtual IIS.Poslednijj.DetailArrayOfТЧЗаказ Заказ
        {
            get
            {
                // *** Start programmer edit section *** (ЗаказПост.Заказ Get start)

                // *** End programmer edit section *** (ЗаказПост.Заказ Get start)
                if ((this.fЗаказ == null))
                {
                    this.fЗаказ = new IIS.Poslednijj.DetailArrayOfТЧЗаказ(this);
                }
                IIS.Poslednijj.DetailArrayOfТЧЗаказ result = this.fЗаказ;
                // *** Start programmer edit section *** (ЗаказПост.Заказ Get end)

                // *** End programmer edit section *** (ЗаказПост.Заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаказПост.Заказ Set start)

                // *** End programmer edit section *** (ЗаказПост.Заказ Set start)
                this.fЗаказ = value;
                // *** Start programmer edit section *** (ЗаказПост.Заказ Set end)

                // *** End programmer edit section *** (ЗаказПост.Заказ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказПостE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказПостE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказПостE", typeof(IIS.Poslednijj.ЗаказПост));
                }
            }
            
            /// <summary>
            /// "ЗаказПостL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказПостL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказПостL", typeof(IIS.Poslednijj.ЗаказПост));
                }
            }
        }
    }
}
