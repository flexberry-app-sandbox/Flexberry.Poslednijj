import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-poslednijj-номенклатура', 'Unit | Serializer | i-i-s-poslednijj-номенклатура', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-poslednijj-номенклатура',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-poslednijj-сост-оплаты',
    'transform:i-i-s-poslednijj-сост-поставок',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
