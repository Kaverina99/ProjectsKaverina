<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Личный кабинет';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Личный кабинет</h2>
        </div>
    </div>


    <br/>

    <ul>
        <li><a href="/index.php?r=sotrudniki/cabinet"><h4>Мой профиль</h4></a></li>
        <li><a href="/index.php?r=sotrudniki/orders"><h4>Все заказы</h4></a></li>
        <li><a href="/index.php?r=sotrudniki/myorders"><h4>Мои заказы</h4></a></li>

    </ul>

    <br/><br/>
    <div class="form-group">
        <a href="/index.php?r=site/off" class="btn btn-primary">Выйти</a>
    </div>

    <br/><br/><br/>

</div>
