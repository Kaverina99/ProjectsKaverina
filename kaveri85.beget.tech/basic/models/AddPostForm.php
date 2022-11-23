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
class AddPostForm extends Model
{
    public $title;
    public $content;
    public $alias;
    public $image_url;

}
