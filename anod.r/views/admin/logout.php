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
        <li><a href="/index.php?r=admin/cabinet"><h4>Мой профиль</h4></a></li>
        <li><a href="/index.php?r=admin/orders"><h4>Заказы</h4></a></li>
        <li><a href="/index.php?r=admin/sotrudniki"><h4>Сотрудники</h4></a></li>
        <li><a href="/index.php?r=admin/clients"><h4>Клиенты</h4></a></li>
    </ul>

    <br/>
    <div class="form-group">
        <a href="/index.php?r=site/off" class="btn btn-primary">Выйти</a>
    </div>

    <br/><br/><br/>

</div>
