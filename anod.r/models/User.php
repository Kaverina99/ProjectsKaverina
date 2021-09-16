<?php

namespace app\models;

use yii\db\ActiveRecord;
use yii\web\IdentityInterface;

class User extends ActiveRecord implements IdentityInterface
{
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'surname' => 'Фамилия',
            'name' => 'Имя',
            'patronymic' => 'Отчество',
            'phone' => 'Телефон',
            'password' => 'Пароль'

        ];
    }


    public function rules()
    {
        return [
            [['email', 'password', 'surname', 'name','patronymic','phone'],
                'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['email', 'email'],
            ['password', 'string', 'min' => 6],
            ['phone', 'string', 'max' => 12]

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























