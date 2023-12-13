import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISPoslednijjЕдиницыИзмерLForm from './forms/i-i-s-poslednijj-единицы-измер-l';
import IISPoslednijjЗаказПостLForm from './forms/i-i-s-poslednijj-заказ-пост-l';
import IISPoslednijjКонтрагентыLForm from './forms/i-i-s-poslednijj-контрагенты-l';
import IISPoslednijjНоменклатураLForm from './forms/i-i-s-poslednijj-номенклатура-l';
import IISPoslednijjОрганизацииLForm from './forms/i-i-s-poslednijj-организации-l';
import IISPoslednijjОтчетОЗакLForm from './forms/i-i-s-poslednijj-отчет-о-зак-l';
import IISPoslednijjПланЗакупокLForm from './forms/i-i-s-poslednijj-план-закупок-l';
import IISPoslednijjСкладыLForm from './forms/i-i-s-poslednijj-склады-l';
import IISPoslednijjЕдиницыИзмерEForm from './forms/i-i-s-poslednijj-единицы-измер-e';
import IISPoslednijjЗаказПостEForm from './forms/i-i-s-poslednijj-заказ-пост-e';
import IISPoslednijjКонтрагентыEForm from './forms/i-i-s-poslednijj-контрагенты-e';
import IISPoslednijjНоменклатураEForm from './forms/i-i-s-poslednijj-номенклатура-e';
import IISPoslednijjОрганизацииEForm from './forms/i-i-s-poslednijj-организации-e';
import IISPoslednijjОтчетОЗакEForm from './forms/i-i-s-poslednijj-отчет-о-зак-e';
import IISPoslednijjПланЗакупокEForm from './forms/i-i-s-poslednijj-план-закупок-e';
import IISPoslednijjСкладыEForm from './forms/i-i-s-poslednijj-склады-e';
import IISPoslednijjЕдиницыИзмерModel from './models/i-i-s-poslednijj-единицы-измер';
import IISPoslednijjЗаказПостModel from './models/i-i-s-poslednijj-заказ-пост';
import IISPoslednijjКонтрагентыModel from './models/i-i-s-poslednijj-контрагенты';
import IISPoslednijjНоменклатураModel from './models/i-i-s-poslednijj-номенклатура';
import IISPoslednijjОрганизацииModel from './models/i-i-s-poslednijj-организации';
import IISPoslednijjОтчетОЗакModel from './models/i-i-s-poslednijj-отчет-о-зак';
import IISPoslednijjПланЗакупокModel from './models/i-i-s-poslednijj-план-закупок';
import IISPoslednijjПланModel from './models/i-i-s-poslednijj-план';
import IISPoslednijjСкладыModel from './models/i-i-s-poslednijj-склады';
import IISPoslednijjТЧЗаказModel from './models/i-i-s-poslednijj-т-ч-заказ';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-poslednijj-единицы-измер': IISPoslednijjЕдиницыИзмерModel,
    'i-i-s-poslednijj-заказ-пост': IISPoslednijjЗаказПостModel,
    'i-i-s-poslednijj-контрагенты': IISPoslednijjКонтрагентыModel,
    'i-i-s-poslednijj-номенклатура': IISPoslednijjНоменклатураModel,
    'i-i-s-poslednijj-организации': IISPoslednijjОрганизацииModel,
    'i-i-s-poslednijj-отчет-о-зак': IISPoslednijjОтчетОЗакModel,
    'i-i-s-poslednijj-план-закупок': IISPoslednijjПланЗакупокModel,
    'i-i-s-poslednijj-план': IISPoslednijjПланModel,
    'i-i-s-poslednijj-склады': IISPoslednijjСкладыModel,
    'i-i-s-poslednijj-т-ч-заказ': IISPoslednijjТЧЗаказModel
  },

  'application-name': 'Poslednijj',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Poslednijj',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Poslednijj',
          title: 'Poslednijj'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        poslednijj: {
          caption: 'Poslednijj',
          title: 'Poslednijj',
          'i-i-s-poslednijj-склады-l': {
            caption: 'Склады',
            title: ''
          },
          'i-i-s-poslednijj-отчет-о-зак-l': {
            caption: 'Отчет о зак',
            title: ''
          },
          'i-i-s-poslednijj-план-закупок-l': {
            caption: 'План закупок',
            title: ''
          },
          'i-i-s-poslednijj-заказ-пост-l': {
            caption: 'Заказ пост',
            title: ''
          },
          'i-i-s-poslednijj-номенклатура-l': {
            caption: 'Номенклатура',
            title: ''
          },
          'i-i-s-poslednijj-организации-l': {
            caption: 'Организации',
            title: ''
          },
          'i-i-s-poslednijj-контрагенты-l': {
            caption: 'Контрагенты',
            title: ''
          },
          'i-i-s-poslednijj-единицы-измер-l': {
            caption: 'Единицы измер',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-poslednijj-единицы-измер-l': IISPoslednijjЕдиницыИзмерLForm,
    'i-i-s-poslednijj-заказ-пост-l': IISPoslednijjЗаказПостLForm,
    'i-i-s-poslednijj-контрагенты-l': IISPoslednijjКонтрагентыLForm,
    'i-i-s-poslednijj-номенклатура-l': IISPoslednijjНоменклатураLForm,
    'i-i-s-poslednijj-организации-l': IISPoslednijjОрганизацииLForm,
    'i-i-s-poslednijj-отчет-о-зак-l': IISPoslednijjОтчетОЗакLForm,
    'i-i-s-poslednijj-план-закупок-l': IISPoslednijjПланЗакупокLForm,
    'i-i-s-poslednijj-склады-l': IISPoslednijjСкладыLForm,
    'i-i-s-poslednijj-единицы-измер-e': IISPoslednijjЕдиницыИзмерEForm,
    'i-i-s-poslednijj-заказ-пост-e': IISPoslednijjЗаказПостEForm,
    'i-i-s-poslednijj-контрагенты-e': IISPoslednijjКонтрагентыEForm,
    'i-i-s-poslednijj-номенклатура-e': IISPoslednijjНоменклатураEForm,
    'i-i-s-poslednijj-организации-e': IISPoslednijjОрганизацииEForm,
    'i-i-s-poslednijj-отчет-о-зак-e': IISPoslednijjОтчетОЗакEForm,
    'i-i-s-poslednijj-план-закупок-e': IISPoslednijjПланЗакупокEForm,
    'i-i-s-poslednijj-склады-e': IISPoslednijjСкладыEForm
  },

});

export default translations;
