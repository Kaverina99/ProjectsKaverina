<?php

namespace app\models;

use Yii;
use yii\base\BaseObject;
use yii\base\Model;

class Message extends Model
{
    public $message;
    public $clientFK = 6;
    public $sotrudnikFK = 7;
    public $name;


    public function attributeLabels()
    {
        return [
            'message' => ' ',

        ];
    }


    public function rules()
    {
        return [
            [['message'], 'required', 'message' => ' '],
            ['message', 'string', 'max' => 400]
        ];
    }

    public function message()
    {
        $chat = new Chat();
        if (Yii::$app->user->identity->getId() == 6)
            $chat->name = 'Егор';
        else
            $chat->name = 'Валентин';

        $chat->message = $this->message;
        $chat->datetime = date("Y.m.d H:i");
        $chat->clientFK = $this->clientFK;
        $chat->sotrudnikFK = $this->sotrudnikFK;

        return $chat->save();
    }
}
