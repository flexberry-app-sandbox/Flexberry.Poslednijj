import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  датаНачала: DS.attr('date'),
  датаОкончания: DS.attr('date'),
  номер: DS.attr('number'),
  состОтгрузки: DS.attr('i-i-s-poslednijj-сост-поставок'),
  состояниеОплаты: DS.attr('i-i-s-poslednijj-сост-оплаты'),
  суммаВклНДС: DS.attr('boolean'),
  суммаДокумента: DS.attr('number'),
  контрагенты: DS.belongsTo('i-i-s-poslednijj-контрагенты', { inverse: null, async: false }),
  организации: DS.belongsTo('i-i-s-poslednijj-организации', { inverse: null, async: false }),
  склады: DS.belongsTo('i-i-s-poslednijj-склады', { inverse: null, async: false }),
  тЧЗаказ: DS.hasMany('i-i-s-poslednijj-т-ч-заказ', { inverse: 'отчетОЗак', async: false })
});

export let ValidationRules = {
  датаНачала: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.датаНачала.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  датаОкончания: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.датаОкончания.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  номер: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  состОтгрузки: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.состОтгрузки.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  состояниеОплаты: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.состояниеОплаты.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  суммаВклНДС: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.суммаВклНДС.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  суммаДокумента: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.суммаДокумента.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  контрагенты: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.контрагенты.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  организации: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.организации.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  склады: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.склады.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  тЧЗаказ: {
    descriptionKey: 'models.i-i-s-poslednijj-отчет-о-зак.validations.тЧЗаказ.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ОтчетОЗакE', 'i-i-s-poslednijj-отчет-о-зак', {
    номер: attr('Номер', { index: 0 }),
    датаНачала: attr('Дата начала', { index: 1 }),
    датаОкончания: attr('Дата окончания', { index: 2 }),
    состОтгрузки: attr('Сост отгрузки', { index: 3 }),
    состояниеОплаты: attr('Состояние оплаты', { index: 4 }),
    суммаВклНДС: attr('Сумма вкл НДС', { index: 5 }),
    суммаДокумента: attr('Сумма документа', { index: 6 }),
    тЧЗаказ: hasMany('i-i-s-poslednijj-т-ч-заказ', 'заказ', {
      количество: attr('Количество', { index: 0 }),
      цена: attr('Цена', { index: 1 }),
      суммаНДС: attr('Сумма НДС', { index: 2 }),
      сумма: attr('Сумма', { index: 3 }),
      этоУслуга: attr('Это услуга', { index: 4 })
    })
  });

  modelClass.defineProjection('ОтчетОЗакL', 'i-i-s-poslednijj-отчет-о-зак', {
    номер: attr('Номер', { index: 0 }),
    суммаДокумента: attr('Сумма документа', { index: 1 }),
    датаНачала: attr('Дата начала', { index: 2 }),
    состОтгрузки: attr('Сост отгрузки', { index: 3 }),
    состояниеОплаты: attr('Состояние оплаты', { index: 4 }),
    датаОкончания: attr('Дата окончания', { index: 5 }),
    суммаВклНДС: attr('Сумма вкл НДС', { index: 6 })
  });
};
