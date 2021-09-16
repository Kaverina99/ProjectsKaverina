<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ торцовых уплотнений для насосов';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ торцовых уплотнений для насосов</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">


            <?php $form = ActiveForm::begin(['id' => 'order1-form']); ?>

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
            <?= $form->field($model, 'typeYplotn')->textInput() ?>
            <?= $form->field($model, 'skhemaPromyvkiGOST')->textInput() ?>
            <?= $form->field($model, 'shtutsera')->textInput() ?>
            <?= $form->field($model, 'typeNasosa')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'markaNasosa')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'oborotyDvigatelya')->textInput() ?>
                </div>
            </div>
            <?= $form->field($model, 'napravlVrashchen')->textInput() ?>
            <?= $form->field($model, 'promyvSreda')->textInput() ?>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'temperPromyv')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'davlPromyv')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'classVzryvoopasZony')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'markirovkaVzryvozashch')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'nameSreda')->textInput() ?>
            <?= $form->field($model, 'sostavSreda')->textInput() ?>
            <?= $form->field($model, 'pH')->textInput() ?>

            <div class="form-row">
                <table width="100%">
                    <tr>
                        <td width="50%"><center><strong>Характеристики</strong></center></td>
                        <td width="25%"><center><strong>Минимальный</strong></center></td>
                        <td width="25%"><center><strong>Максимальный</strong></center></td>
                    </tr>
                    <tr>
                        <td width="50%">Давление в сальниковой камере, МПа</td>
                        <td width="25%">
                            <?= $form->field($model, 'davlInSalCameraMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'davlInSalCameraMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Давление на входе, МПа</td>
                        <td width="25%">
                            <?= $form->field($model, 'davlNaVkhodeMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'davlNaVkhodeMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Давление на напоре, МПа</td>
                        <td width="25%">
                            <?= $form->field($model, 'davlNaNaporeMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'davlNaNaporeMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Температура, °С</td>
                        <td width="25%">
                            <?= $form->field($model, 'temperMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'temperMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Температура окружающей среды, °С</td>
                        <td width="25%">
                            <?= $form->field($model, 'temperOkrSredaMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'temperOkrSredaMax')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>

            <div class="form-row">
                <table width="100%">
                    <tr><td style="width: 45%;"><img style="width: 100%;" src="/images/Схема1.jpg" /></td>
                        <td style="width: 5%; color: white">Пробел</td>
                        <td>
                            <div class="form-group">
                                <?= $form->field($model, 'Dv')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'Dvt')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'D1')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'L1')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'L2')->textInput() ?>
                            </div>

                        </td></tr>
                </table>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'D2')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'D3')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'Dsh')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'N')->textInput() ?>
                </div>
            </div>


            <?= $form->field($model, 'NalichieResKan')->textarea() ?>

            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order1-button']) ?>
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
