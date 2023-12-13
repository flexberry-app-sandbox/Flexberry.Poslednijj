import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  датаНачала: DS.attr('date', { defaultValue() { return new Date(); } }),
  номер: DS.attr('number'),
  контрагенты: DS.belongsTo('i-i-s-poslednijj-контрагенты', { inverse: null, async: false }),
  организации: DS.belongsTo('i-i-s-poslednijj-организации', { inverse: null, async: false }),
  склады: DS.belongsTo('i-i-s-poslednijj-склады', { inverse: null, async: false }),
  план: DS.hasMany('i-i-s-poslednijj-план', { inverse: 'планЗакупок', async: false })
});

export let ValidationRules = {
  датаНачала: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.датаНачала.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  номер: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  контрагенты: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.контрагенты.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  организации: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.организации.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  склады: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.склады.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  план: {
    descriptionKey: 'models.i-i-s-poslednijj-план-закупок.validations.план.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ПланЗакупокE', 'i-i-s-poslednijj-план-закупок', {
    номер: attr('Номер', { index: 0 }),
    датаНачала: attr('Дата начала', { index: 1 }),
    план: hasMany('i-i-s-poslednijj-план', 'План', {
      количество: attr('Количество', { index: 0 }),
      этоУслуга: attr('Это услуга', { index: 1 })
    })
  });

  modelClass.defineProjection('ПланЗакупокL', 'i-i-s-poslednijj-план-закупок', {
    датаНачала: attr('Дата начала', { index: 0 }),
    номер: attr('Номер', { index: 1 })
  });
};
