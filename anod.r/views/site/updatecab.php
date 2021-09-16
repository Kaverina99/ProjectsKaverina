<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */

use app\models\User;
use yii\helpers\Html;
use yii\bootstrap\ActiveForm;

$this->title = 'Личный кабинет';

?>
<div class="site-about">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Редактирование профиля</h2>
        </div>
    </div>

    <br/>

    <?php $form = ActiveForm::begin(['class'=> 'form-horizontal']); ?>

    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'surname') ?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'name') ?>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'patronymic')?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'phone') ?>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            <?= $form->field($model, 'email')?>
        </div>
        <div class="form-group col-md-6">
            <?= $form->field($model, 'password')->passwordInput() ?>
        </div>
    </div>

    <?= Html::submitButton('Сохранить', ['class' => 'btn btn-primary'] ) ?>


    <?php ActiveForm::end(); ?>



    <br/><br/><br/>

</div>
