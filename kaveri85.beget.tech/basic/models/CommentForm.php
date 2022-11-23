<?php

namespace app\models;

use Yii;
use yii\base\Model;

/**
 * LoginForm is the model behind the login form.
 *
 * @property-read User|null $user
 *
 */
class CommentForm extends Model
{
    public $full_name;
    public $content;
    public $post_FK;

}
