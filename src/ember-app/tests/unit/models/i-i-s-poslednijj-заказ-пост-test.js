import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-poslednijj-заказ-пост', 'Unit | Model | i-i-s-poslednijj-заказ-пост', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-poslednijj-единицы-измер',
    'model:i-i-s-poslednijj-заказ-пост',
    'model:i-i-s-poslednijj-контрагенты',
    'model:i-i-s-poslednijj-номенклатура',
    'model:i-i-s-poslednijj-организации',
    'model:i-i-s-poslednijj-отчет-о-зак',
    'model:i-i-s-poslednijj-план-закупок',
    'model:i-i-s-poslednijj-план',
    'model:i-i-s-poslednijj-склады',
    'model:i-i-s-poslednijj-т-ч-заказ',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
