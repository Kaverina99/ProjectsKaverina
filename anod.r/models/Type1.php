<?php

namespace app\models;

use yii\db\ActiveRecord;
use yii\web\IdentityInterface;

class Type1 extends ActiveRecord implements IdentityInterface
{
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
            'davlNaVkhodeMin' => '(Min) Давление в сальниковой камере, МПа',
            'davlNaVkhodeMax' => '(Max) Давление в сальниковой камере, МПа',

            'davlNaNaporeMin' => '(Min) Давление на входе, МПа',
            'davlNaNaporeMax' => '(Max) Давление на входе, МПа',
            'davlInSalCameraMin' => '(Min) Давление на напоре, МПа',
            'davlInSalCameraMax' => '(Max) Давление на напоре, МПа',
            'temperMin' => '(Min) Температура, °С',
            'temperMax' => '(Max) Температура, °С',

            'temperOkrSredaMin' => '(Min) Температура окружающей среды, °С',
            'temperOkrSredaMax' => '(Max) Температура окружающей среды, °С',
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

    public static function findIdentity($id)
    {
        return self::findOne($id);
    }

    public static function findIdentityByAccessToken($token, $type = null)
    {

    }

    public function getId()
    {
        return $this->id;
    }




    public function getAuthKey()
    {

    }

    public function validateAuthKey($authKey)
    {

    }
}

