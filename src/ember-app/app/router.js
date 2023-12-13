import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-poslednijj-единицы-измер-l');
  this.route('i-i-s-poslednijj-единицы-измер-e',
  { path: 'i-i-s-poslednijj-единицы-измер-e/:id' });
  this.route('i-i-s-poslednijj-единицы-измер-e.new',
  { path: 'i-i-s-poslednijj-единицы-измер-e/new' });
  this.route('i-i-s-poslednijj-заказ-пост-l');
  this.route('i-i-s-poslednijj-заказ-пост-e',
  { path: 'i-i-s-poslednijj-заказ-пост-e/:id' });
  this.route('i-i-s-poslednijj-заказ-пост-e.new',
  { path: 'i-i-s-poslednijj-заказ-пост-e/new' });
  this.route('i-i-s-poslednijj-контрагенты-l');
  this.route('i-i-s-poslednijj-контрагенты-e',
  { path: 'i-i-s-poslednijj-контрагенты-e/:id' });
  this.route('i-i-s-poslednijj-контрагенты-e.new',
  { path: 'i-i-s-poslednijj-контрагенты-e/new' });
  this.route('i-i-s-poslednijj-номенклатура-l');
  this.route('i-i-s-poslednijj-номенклатура-e',
  { path: 'i-i-s-poslednijj-номенклатура-e/:id' });
  this.route('i-i-s-poslednijj-номенклатура-e.new',
  { path: 'i-i-s-poslednijj-номенклатура-e/new' });
  this.route('i-i-s-poslednijj-организации-l');
  this.route('i-i-s-poslednijj-организации-e',
  { path: 'i-i-s-poslednijj-организации-e/:id' });
  this.route('i-i-s-poslednijj-организации-e.new',
  { path: 'i-i-s-poslednijj-организации-e/new' });
  this.route('i-i-s-poslednijj-отчет-о-зак-l');
  this.route('i-i-s-poslednijj-отчет-о-зак-e',
  { path: 'i-i-s-poslednijj-отчет-о-зак-e/:id' });
  this.route('i-i-s-poslednijj-отчет-о-зак-e.new',
  { path: 'i-i-s-poslednijj-отчет-о-зак-e/new' });
  this.route('i-i-s-poslednijj-план-закупок-l');
  this.route('i-i-s-poslednijj-план-закупок-e',
  { path: 'i-i-s-poslednijj-план-закупок-e/:id' });
  this.route('i-i-s-poslednijj-план-закупок-e.new',
  { path: 'i-i-s-poslednijj-план-закупок-e/new' });
  this.route('i-i-s-poslednijj-склады-l');
  this.route('i-i-s-poslednijj-склады-e',
  { path: 'i-i-s-poslednijj-склады-e/:id' });
  this.route('i-i-s-poslednijj-склады-e.new',
  { path: 'i-i-s-poslednijj-склады-e/new' });
});

export default Router;
