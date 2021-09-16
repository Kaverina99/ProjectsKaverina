<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Order6  extends Model
{
    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;

    public $count;
    public $typeArmat;
    public $naznachenie;
    public $davlNominal;
    public $prohodNominal;
    public $prisoyedineniye;

    public $otvetnyyeFlantsy;
    public $dTruboprovoda;
    public $rabDavlMin;
    public $rabDavlMax;
    public $rabTemperMin;
    public $rabTemperMax;

    public $tempOkrSrMin;
    public $tempOkrSrMax;
    public $maxPerepadDavl;
    public $nameRabSr;
    public $himSostav;
    public $agregatSostoyaniye;

    public $nalichiyeTverdChast;
    public $podKakimPerepadomDavl;
    public $trebovaniyaPoNermetichnosti;
    public $materialKor;
    public $vnutrDetali;
    public $truboprovod;

    public $zakazFK = 6;

    public function attributeLabels()
    {
        return [
            'nameOrg' => 'Наименование организации',
            'addressOrg' => 'Адрес организации',
            'codeCity' => 'Код города',
            'fax' => 'Факс организации',
            'FIO' => 'ФИО контактного лица',
            'position' => 'Должность контактного лица',
            'phone' => 'Телефон контактного лица/организации',

            'count' => 'Количество заказываемых арматур, шт.',
            'typeArmat' => 'Тип арматуры',
            'naznachenie' => 'Назначение',
            'davlNominal' => 'Давление номинальное, PN',
            'prohodNominal' => 'Проход номинальный, DN',
            'prisoyedineniye' => 'Присоединение',

            'otvetnyyeFlantsy' => 'Ответные фланцы',
            'dTruboprovoda' => 'Диаметр трубопровода, мм',
            'rabDavlMin' => ' ',
            'rabDavlMax' => ' ',
            'rabTemperMin' => ' ',
            'rabTemperMax' => ' ',

            'tempOkrSrMin' => ' ',
            'tempOkrSrMax' => ' ',
            'maxPerepadDavl' => 'Максимальный перепад давления',
            'nameRabSr' => 'Наименование рабочей среды',
            'himSostav' => 'Химический состав',
            'agregatSostoyaniye' => 'Агрегатное состояние',

            'nalichiyeTverdChast' => 'Наличие твердых частиц, механических или абразивных примесей',
            'podKakimPerepadomDavl' => ' Под каким перепадом давления происходит открытие, закрытие',
            'trebovaniyaPoNermetichnosti' => ' Требования по герметичности арматуры',
            'materialKor' => 'Материал корпуса',
            'vnutrDetali' => 'Внутренние детали',
            'truboprovod' => 'Трубопровод'

        ];
    }



    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'typeArmat', 'naznachenie', 'davlNominal','prohodNominal','prisoyedineniye',
                'otvetnyyeFlantsy', 'dTruboprovoda', 'rabDavlMin', 'rabDavlMax','rabTemperMin','rabTemperMax',
                'tempOkrSrMin', 'tempOkrSrMax', 'maxPerepadDavl', 'nameRabSr','himSostav','agregatSostoyaniye',
                'nalichiyeTverdChast', 'podKakimPerepadomDavl', 'trebovaniyaPoNermetichnosti', 'materialKor','vnutrDetali','truboprovod'
            ], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']

        ];
    }


    public function order6()
    {
        $type6 = new Type1();
        $type6->nameOrg = $this->nameOrg;
        $type6->addressOrg = $this->addressOrg;
        $type6->codeCity = $this->codeCity;
        $type6->fax = $this->fax;
        $type6->FIO = $this->FIO;
        $type6->position = $this->position;
        $type6->phone = $this->phone;

        $type6->count = $this->count;
        $type6->typeArmat = $this->typeArmat;
        $type6->naznachenie = $this->naznachenie;
        $type6->davlNominal = $this->davlNominal;
        $type6->prohodNominal = $this->prohodNominal;
        $type6->prisoyedineniye = $this->prisoyedineniye;

        $type6->otvetnyyeFlantsy = $this->otvetnyyeFlantsy;
        $type6->dTruboprovoda = $this->dTruboprovoda;
        $type6->rabDavlMin = $this->rabDavlMin;
        $type6->rabDavlMax = $this->rabDavlMax;
        $type6->rabTemperMin = $this->rabTemperMin;
        $type6->rabTemperMax = $this->rabTemperMax;

        $type6->tempOkrSrMin = $this->tempOkrSrMin;
        $type6->tempOkrSrMax = $this->tempOkrSrMax;
        $type6->maxPerepadDavl = $this->maxPerepadDavl;
        $type6->nameRabSr = $this->nameRabSr;
        $type6->himSostav = $this->himSostav;
        $type6->agregatSostoyaniye = $this->agregatSostoyaniye;

        $type6->nalichiyeTverdChast = $this->nalichiyeTverdChast;
        $type6->podKakimPerepadomDavl = $this->podKakimPerepadomDavl;
        $type6->trebovaniyaPoNermetichnosti = $this->trebovaniyaPoNermetichnosti;
        $type6->materialKor = $this->materialKor;
        $type6->vnutrDetali = $this->vnutrDetali;
        $type6->truboprovod = $this->truboprovod;

        $type6->zakazFK = $this->zakazFK;

        return $type6->save();
    }



}


