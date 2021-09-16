<?php

namespace app\models;

use yii\base\Model;

class Addsotr extends Model
{
    public $surname;
    public $name;
    public $patronymic;
    public $phone;
    public $email;
    public $password;
    public $roleFK = 3;

    public function attributeLabels()
    {
        return [
            'surname' => ' Фамилия',
            'name' => ' Имя',
            'patronymic' => ' Отчество',
            'phone' => 'Телефон',
            'email' => 'Email/Логин',
            'password' => 'Пароль',

        ];
    }


    public function rules()
    {
        return [
            [['email', 'password', 'surname', 'name','patronymic','phone'], 'required', 'message' => 'Поле обязательно для заполнения !!!'],
            ['email', 'email'],
            ['email', 'unique', 'targetClass' => 'app\models\User'],
            ['password', 'string', 'min' => 6],
            ['phone', 'string', 'max' => 12]

        ];
    }

    public function addsotr()
    {
        $user = new User();
        $user->surname = $this->surname;
        $user->name = $this->name;
        $user->patronymic = $this->patronymic;
        $user->phone = $this->phone;
        $user->email = $this->email;
        $user->password = $this->password;
        //$user->password = sha1($this->password);
        $user->roleFK = $this->roleFK;

        return $user->save();
    }
}
