<?php

namespace app\models;

use yii\db\ActiveRecord;
use yii\web\IdentityInterface;

class Zakaz extends ActiveRecord implements IdentityInterface
{
    public function attributeLabels()
    {
        return [

            'id' => '№ заказа',
            'nameOrg' => 'Наименование организации',
            'addressOrg' => 'Адрес организации',
            'codeCity' => 'Код города',
            'phone' => 'Телефон организации',
            'fax' => 'Факс организации',
            'FIO' => 'ФИО контактного лица',
            'position' => 'Должность контактного лица',
            'statusFK' => 'Текущий статус заказа'
        ];
    }
    public function rules()
    {
        return [
            [['nameOrg', 'addressOrg','codeCity','phone' ,'fax' , 'FIO','position' ,'statusFK'],
                'required', 'message' => 'Поле обязательно для заполнения !!!'],
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

