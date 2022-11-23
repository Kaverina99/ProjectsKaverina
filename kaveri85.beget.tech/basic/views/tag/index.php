<?php

/** @var yii\web\View $this */

use yii\helpers\Html;
use yii\widgets\ActiveForm;


$this->title = "Теги статей";
$this->params['breadcrumbs'][] = $this->title;

?>
<div class="site-about">

    <h1><?= Html::encode($this->title) ?></h1>

    <? if(!(Yii::$app->user->isGuest)) { ?>
        <h3>Добавить тег</h3>
        <?php $form = ActiveForm::begin() ?>
            <?= $form->field($model, 'title')->label('Заголовок') ?>
            <?= $form->field($model, 'description')->label('Описание тега') ?>
            <?= $form->field($model, 'alias')->label('alias') ?>
            <?= Html::submitButton('Добавить', ['class' => 'btn btn-success']) ?>
        <?php ActiveForm::end(); ?>
        <br>
    <?}?>


    <?= app\components\TagWidget::run2(Yii::$app->user->isGuest)?>

</div>
