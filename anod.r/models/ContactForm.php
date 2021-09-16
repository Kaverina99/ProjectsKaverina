<?php

namespace app\models;

use Yii;
use yii\base\Model;

/**
 * ContactForm is the model behind the contact form.
 */
class ContactForm extends Model
{
    public $name;
    public $email;
    public $subject;
    public $text;

    public function attributeLabels()
    {
        return [
            'name' => ' ФИО',
            'email' => 'Email',
            'subject' => 'Тема сообщения',
            'text' => 'Текст сообщения',
        ];
    }

    /**
     * @return array the validation rules.
     */
    public function rules()
    {
        return [
            // name, email, subject and text are required
            [['name', 'email', 'subject', 'text'], 'required', 'message' => 'Данное поле обязательно для заполнения!'],
            // email has to be a valid email address
            ['email', 'email'],
            ['name', 'string', 'min' => 4]

        ];
    }


    /**
     * Sends an email to the specified email address using the information collected by this model.
     * @param string $email the target email address
     * @return bool whether the model passes validation
     */
    public function contact($email)
    {
        if ($this->validate()) {
            Yii::$app->mailer->compose()
                ->setTo($email)
                ->setFrom([$email => $this->name])
                ->setSubject($this->subject)
                ->setTextBody($this->text)
                ->send();

            return true;
        }
        return false;
    }
}


