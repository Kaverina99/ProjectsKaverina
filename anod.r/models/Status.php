<?php

namespace app\models;

use yii\db\ActiveRecord;
use yii\web\IdentityInterface;

class Status extends ActiveRecord implements IdentityInterface
{
    public function attributeLabels()
    {
        return [
            'name' => 'Статус заказа',
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























