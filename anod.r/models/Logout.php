<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class Logout extends Model
{
    public $email;
    public $password;
    public $roleFK;

    public function attributeLabels()
    {
        return [
            'email' => 'Email',
            'password' => 'Пароль',
            'roleFK' => 'Роль',
        ];
    }

    /**
     * @return array the validation rules.
     */
    public function rules()
    {
        return [
            // name, email, subject and text are required
            [['email', 'password'], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['email', 'email'],

        ];
    }


}


