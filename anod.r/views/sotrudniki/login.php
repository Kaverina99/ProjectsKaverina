<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Вход';

?>
<div class="site-login">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Вход</h2>
        </div>
    </div>


    <br/>
    <h3>Пожалуйста, заполните следующие поля для входа:</h3>

    <?php $form = ActiveForm::begin(); ?>

    <?= $form->field($login_model, 'email')->textInput(['autofocus' => true]) ?>

    <?= $form->field($login_model, 'password')->passwordInput() ?>


    <div>
        <button type="submit" class="btn btn-primary">Войти</button>
    </div>


    <?php ActiveForm::end(); ?>

    <br/><br/><br/><br/>

</div>
