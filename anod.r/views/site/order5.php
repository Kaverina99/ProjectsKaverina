<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ подшипников скольжения';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ подшипников скольжения</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">

            <?php $form = ActiveForm::begin(['id' => 'order5-form']); ?>

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

            <?= $form->field($model, 'nameAndMarkaApp')->textInput() ?>
            <?= $form->field($model, 'rabSredaInZoneRazm')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'chastotaVrashchVala')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'massaRotora')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'nameRabSreda')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'temperat')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'davlInPolostiPodsh')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'vozmozhPodachiInPol')->textarea() ?>
            <?= $form->field($model, 'osobenGeomVala')->textarea() ?>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Опорный подшипник</strong></center></td>
                        <td width="25%"><center><strong>Упорный подшипник</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">d - Диаметр вала в месте установки подшипника, мм</td>
                        <td width="25%">
                            <?= $form->field($model, 'dOpor')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'dYpor')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">L - Длина посадочного места, мм</td>
                        <td width="25%">
                            <?= $form->field($model, 'Lopor')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'Lypor')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">d1 - Диаметр посадочного места, мм</td>
                        <td width="25%">
                            <?= $form->field($model, 'd1opor')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'd1ypor')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">с-1  Частота вращения, об/мин</td>
                        <td width="25%">
                            <?= $form->field($model, 'cOpor')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'cYpor')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Рос - Осевая сила, Кг</td>
                        <td width="25%">
                            <?= $form->field($model, 'PocOpor')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'PocYpor')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>



            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order5-button']) ?>
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
