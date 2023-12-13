import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.poslednijj.caption'),
          title: i18n.t('forms.application.sitemap.poslednijj.title'),
          children: [{
            link: 'i-i-s-poslednijj-склады-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-склады-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-склады-l.title'),
            icon: 'tasks',
            children: null
          }, {
            link: 'i-i-s-poslednijj-отчет-о-зак-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-отчет-о-зак-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-отчет-о-зак-l.title'),
            icon: 'folder open',
            children: null
          }, {
            link: 'i-i-s-poslednijj-план-закупок-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-план-закупок-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-план-закупок-l.title'),
            children: null
          }, {
            link: 'i-i-s-poslednijj-заказ-пост-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-заказ-пост-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-заказ-пост-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-poslednijj-номенклатура-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-номенклатура-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-номенклатура-l.title'),
            icon: 'briefcase',
            children: null
          }, {
            link: 'i-i-s-poslednijj-организации-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-организации-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-организации-l.title'),
            icon: 'address card',
            children: null
          }, {
            link: 'i-i-s-poslednijj-контрагенты-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-контрагенты-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-контрагенты-l.title'),
            children: null
          }, {
            link: 'i-i-s-poslednijj-единицы-измер-l',
            caption: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-единицы-измер-l.caption'),
            title: i18n.t('forms.application.sitemap.poslednijj.i-i-s-poslednijj-единицы-измер-l.title'),
            icon: 'table',
            children: null
          }]
        }
      ]
    };
  }),
})