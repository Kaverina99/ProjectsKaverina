<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ на изготовление арматуры';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ на изготовление арматуры</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">

            <?php $form = ActiveForm::begin(['id' => 'order6-form']); ?>

            <?= $form->field($model, 'nameOrg')->textInput(['autofocus' => true]) ?>
            <?= $form->field($model, 'addressOrg')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'codeCity')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'fax')->textInput() ?>
                </div>
            </div>
            <?= $form->field($model, 'FIO')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'position')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'phone')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'count')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'typeArmat')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'naznachenie')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'davlNominal')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'prohodNominal')->textInput() ?>
                </div>
            </div>
            <?= $form->field($model, 'prisoyedineniye')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'otvetnyyeFlantsy')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'dTruboprovoda')->textInput() ?>
                </div>
            </div>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Минимальный</strong></center></td>
                        <td width="25%"><center><strong>Максимальный</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Рабочее давление</td>
                        <td width="25%">
                            <?= $form->field($model, 'rabDavlMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'rabDavlMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Рабочая температура</td>
                        <td width="25%">
                            <?= $form->field($model, 'rabTemperMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'rabTemperMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Температура окружающей среды</td>
                        <td width="25%">
                            <?= $form->field($model, 'tempOkrSrMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'tempOkrSrMax')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'maxPerepadDavl')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'nameRabSr')->textInput() ?>
                </div>
            </div>
            <?= $form->field($model, 'himSostav')->textarea() ?>
            <?= $form->field($model, 'agregatSostoyaniye')->textarea() ?>

            <?= $form->field($model, 'nalichiyeTverdChast')->textarea() ?>
            <?= $form->field($model, 'podKakimPerepadomDavl')->textarea() ?>
            <?= $form->field($model, 'trebovaniyaPoNermetichnosti')->textarea() ?>
            <?= $form->field($model, 'materialKor')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vnutrDetali')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'truboprovod')->textInput() ?>
                </div>
            </div>


            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order6-button']) ?>
            </div>
            <p><em>Нажимая кнопку "Отправить" Вы выражаете свою заинтересованность и даете полное согласие ООО НПЦ "АНОД"
                    на обработку (хранение и использование) Ваших персональных данных, без средств автоматизации, в соответствии
                    с Федеральным законом от 27.07.2006 года 152-ФЗ "О персональных данных".</em>
            </p>



            <?php ActiveForm::end(); ?>

            <br/><br/><br/>
        </div>
    </div>

</div>
