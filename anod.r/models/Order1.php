<?php

namespace app\models;

use Faker\Provider\DateTime;
use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */


class Order1  extends Model
{

    public $nameOrg;
    public $addressOrg;
    public $codeCity;
    public $fax;
    public $FIO;
    public $position;
    public $phone;
    public $statusFK = 1;
    public $clientFK = 6;
    public $sotrudnikFK = 7;


    public $count;
    public $shtutsera;
    public $skhemaPromyvkiGOST;
    public $typeYplotn;
    public $markaNasosa;
    public $typeNasosa;
    public $oborotyDvigatelya;
    public $napravlVrashchen;
    public $promyvSreda;
    public $temperPromyv;
    public $davlPromyv;
    public $classVzryvoopasZony;
    public $markirovkaVzryvozashch;
    public $nameSreda;
    public $sostavSreda;
    public $pH;
    public $davlInSalCameraMin;
    public $davlInSalCameraMax;
    public $davlNaVkhodeMin;
    public $davlNaVkhodeMax;
    public $davlNaNaporeMin;
    public $davlNaNaporeMax;
    public $temperMin;
    public $temperMax;
    public $temperOkrSredaMin;
    public $temperOkrSredaMax;
    public $Dv;
    public $Dvt;
    public $D1;
    public $L1;
    public $L2;
    public $D2;
    public $D3;
    public $Dsh;
    public $N;
    public $NalichieResKan;
    public $zakazFK = 1;


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


            'count' => 'Количество заказываемых уплотнений, шт.',
            'shtutsera' => 'Штуцера для обвязки',
            'skhemaPromyvkiGOST' => 'Схема промывки по ГОСТ 32600-2013 (API 682)',
            'typeYplotn' => 'Предпочтительный тип уплотнения',
            'markaNasosa' => 'Марка насоса/Тип API 610',
            'typeNasosa' => 'Тип насоса',

            'oborotyDvigatelya' => 'Обороты двигателя, об/мин, с-1',
            'napravlVrashchen' => 'Направление вращения со стороны двигателя',
            'promyvSreda' => 'Промывающая среда',
            'temperPromyv' => 'Темп. промывки, °С  ',
            'davlPromyv' => 'Давл. промывки, МПа',
            'classVzryvoopasZony' => 'Класс взрывоопасной зоны',

            'markirovkaVzryvozashch' => 'Маркировка взрывозащиты',
            'nameSreda' => 'Наименование среды',
            'sostavSreda' => 'Состав среды (компоненты)',
            'pH' => 'Показатель рН (для водных растворов)',
            'davlNaVkhodeMin' => ' ',
            'davlNaVkhodeMax' => ' ',

            'davlNaNaporeMin' => ' ',
            'davlNaNaporeMax' => ' ',
            'davlInSalCameraMin' => ' ',
            'davlInSalCameraMax' => ' ',
            'temperMin' => ' ',
            'temperMax' => ' ',

            'temperOkrSredaMin' => ' ',
            'temperOkrSredaMax' => ' ',
            'Dv' => 'Dв - Диаметр вала (без втулки) в месте установки уплотнения',
            'Dvt' => 'Dвт - Диаметр втулки (если имеется)',
            'D1' => 'D1 - Диаметр сальниковой камеры',
            'L1' => 'L1 - Глубина сальниковой камеры',

            'L2' => 'L2 - Максимальная величина монтажного пространства (От торца сальниковой камеры до подшипника или фланца)',
            'D2' => 'D2 - Диаметр окружности центров отверстий под шпильки крепления',
            'D3' => 'D3 - Максимальные диаметр фланца торцового уплотнения',
            'Dsh' => 'Dш - Диметр шпильки',
            'N' => 'N - Количество отверстий под крепление шпильки',
            'NalichieResKan' => 'Наличие резьбы, канавок, уступов и т.д. на валу в пределах размеров L1, L2. Их расположение относительно торца сальниковой камеры. Указать при наличии.',
        ];
    }


    public function rules()
    {
        return [
            [[
                'nameOrg', 'addressOrg', 'codeCity', 'fax','FIO','position','phone',
                'count', 'shtutsera', 'skhemaPromyvkiGOST', 'typeYplotn','markaNasosa','typeNasosa',
                'oborotyDvigatelya', 'napravlVrashchen', 'promyvSreda', 'temperPromyv','davlPromyv','classVzryvoopasZony',
                'markirovkaVzryvozashch', 'nameSreda', 'sostavSreda', 'pH','davlNaVkhodeMin','davlNaVkhodeMax',
                'davlNaNaporeMin', 'davlNaNaporeMax', 'davlInSalCameraMin', 'davlInSalCameraMax','temperMin','temperMax',
                'temperOkrSredaMin', 'temperOkrSredaMax', 'Dv', 'Dvt','D1','L1',
                'L2', 'D2', 'D3', 'Dsh','N','NalichieResKan'], 'required', 'message' => 'Поле обязательно для заполнения !'],
            ['count', 'integer', 'message' => 'Знаение поля должно быть целым числом !!!']
           // [['temperPromyv','davlPromyv', 'pH','davlNaVkhodeMin','davlNaVkhodeMax','davlNaNaporeMin', 'davlNaNaporeMax',
           //     'davlInSalCameraMin', 'davlInSalCameraMax','temperMin','temperMax', 'temperOkrSredaMin', 'temperOkrSredaMax', 'Dv',
           //     'Dvt','D1','L1','L2','D2', 'D3', 'Dsh','N'], 'integer', 'message' => 'Знаение поля должно быть числом с плавающей точкой !!!']
        ];
    }


    public function order1()
    {
        $zakaz = new Zakaz();
        $zakaz->nameOrg = $this->nameOrg;
        $zakaz->addressOrg = $this->addressOrg;
        $zakaz->codeCity = $this->codeCity;
        $zakaz->fax = $this->fax;
        $zakaz->FIO = $this->FIO;
        $zakaz->position = $this->position;
        $zakaz->phone = $this->phone;
        $zakaz->statusFK = $this->statusFK;
        $zakaz->clientFK = $this->clientFK;
        $zakaz->sotrudnikFK = $this->sotrudnikFK;

        $type1 = new Type1();
        $type1->count = $this->count;
        $type1->shtutsera = $this->shtutsera;
        $type1->skhemaPromyvkiGOST = $this->skhemaPromyvkiGOST;
        $type1->typeYplotn = $this->typeYplotn;
        $type1->markaNasosa = $this->markaNasosa;
        $type1->typeNasosa = $this->typeNasosa;
        $type1->oborotyDvigatelya = $this->oborotyDvigatelya;
        $type1->napravlVrashchen = $this->napravlVrashchen;
        $type1->promyvSreda = $this->promyvSreda;
        $type1->temperPromyv = $this->temperPromyv;
        $type1->davlPromyv = $this->davlPromyv;
        $type1->classVzryvoopasZony = $this->classVzryvoopasZony;
        $type1->markirovkaVzryvozashch = $this->markirovkaVzryvozashch;
        $type1->nameSreda = $this->nameSreda;
        $type1->sostavSreda = $this->sostavSreda;
        $type1->pH = $this->pH;
        $type1->davlInSalCameraMin = $this->davlInSalCameraMin;
        $type1->davlInSalCameraMax = $this->davlInSalCameraMax;
        $type1->davlNaVkhodeMin = $this->davlNaVkhodeMin;
        $type1->davlNaVkhodeMax = $this->davlNaVkhodeMax;
        $type1->davlNaNaporeMin = $this->davlNaNaporeMin;
        $type1->davlNaNaporeMax = $this->davlNaNaporeMax;
        $type1->temperMin = $this->temperMin;
        $type1->temperMax = $this->temperMax;
        $type1->temperOkrSredaMin = $this->temperOkrSredaMin;
        $type1->temperOkrSredaMax = $this->temperOkrSredaMax;
        $type1->Dv = $this->Dv;
        $type1->Dvt = $this->Dvt;
        $type1->D1 = $this->D1;
        $type1->L1 = $this->L1;
        $type1->L2 = $this->L2;
        $type1->D2 = $this->D2;
        $type1->D3 = $this->D3;
        $type1->Dsh = $this->Dsh;
        $type1->N = $this->N;
        $type1->NalichieResKan = $this->NalichieResKan;
        $type1->zakazFK = $this->zakazFK;

        $zakaz->save();
        return $type1->save();

    }


}


