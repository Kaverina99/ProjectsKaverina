<?php


namespace app\models;


use yii\base\Model;

class Login extends Model
{
    public $email;
    public $password;
    public $roleFK = 2;

    public function attributeLabels()
    {
        return [
            'email' => 'Email/Логин',
            'password' => 'Пароль',
        ];
    }

    public function rules()
    {
        return [
            [['email', 'password'], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['email', 'email'],
            ['password', 'validatePassword']
        ];
    }

    public function validatePassword($attribute, $params)
    {
        $user = User::findOne(['email'=>$this->email]);
        if(!$user ||($user->password != $this->password))
            $this->addError($attribute, 'Логин/Email или пароль введен неверно!');

    }
    public function getUser()
    {
        return User::findOne(['email'=>$this->email]);
    }
}