<?php

/* @var $this yii\web\View */
/* @var $form yii\bootstrap\ActiveForm */
/* @var $model app\models\ContactForm */

use yii\helpers\Html;
use yii\bootstrap\ActiveForm;
use yii\captcha\Captcha;

$this->title = 'Заказ торцовых уплотнений для реакторов и мешалок';

?>
<div class="site-contact">
    <br/>
    <div class="full center margin-bottom_30">
        <div class="heading_main text_align_center">
            <h2 style="text-align: center; font-size: 30pt">Заказ торцовых уплотнений для реакторов и мешалок</h2>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">


            <?php $form = ActiveForm::begin(['id' => 'order2-form']); ?>

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
                    <?= $form->field($model, 'nameAndMarka')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'izgotovitel')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vid')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'raspolozheniye')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vidJob')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'ispolzuyemyyeTypeYpl')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'materialPoverkhOborud')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'polozheniyeVala')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'napravlVrashchSoStor')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'speedVrashch')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'dValaVMesteYstan')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'dVnutrBobyshki')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'rZakruglBob')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'namePerekachProdukta')->textInput() ?>

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
                            <?= $form->field($model, 'rabDavlMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'rabDavlMax')->textInput() ?>
                        </td>
                    </tr>
                    <tr>
                        <td width="50%">Давление на входе, МПа</td>
                        <td width="25%">
                            <?= $form->field($model, 'rabTemperMin')->textInput() ?>
                        </td>
                        <td width="25%">
                            <?= $form->field($model, 'rabTemperMax')->textInput() ?>
                        </td>
                    </tr>
                </table>
            </div>

            <?= $form->field($model, 'sostav')->textInput() ?>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'plotnost')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'vyazkost')->textInput() ?>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'pH')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'temperKipeniya')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'dopustimYtechka')->textInput() ?>
            <?= $form->field($model, 'nalichiyeAbrazivKompon')->textInput() ?>
            <?= $form->field($model, 'himSvoystva')->textInput() ?>
            <?= $form->field($model, 'izmenSvoystvSreda')->textInput() ?>
            <?= $form->field($model, 'nameAndSostavZat')->textInput() ?>

            <div class="form-row">
                <table width="100%">
                    <tr><td style="width: 45%;"><img style="width: 100%;" src="/images/Схема2.jpg" /></td>
                        <td style="width: 5%; color: white">Пробел</td>
                        <td>
                            <div class="form-group">
                                <?= $form->field($model, 'D')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'D1')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'D2')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'D3')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'D4')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'Dotv')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'N')->textInput() ?>
                            </div>
                            <div class="form-group">
                                <?= $form->field($model, 'L1')->textInput() ?>
                            </div>
                        </td></tr>
                </table>
            </div>

            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'L2')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'a')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'L3')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'L4')->textInput() ?>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'a1')->textInput() ?>
                </div>
                <div class="form-group col-md-6">
                    <?= $form->field($model, 'a3')->textInput() ?>
                </div>
            </div>

            <?= $form->field($model, 'osobenGeometriiVala')->textInput() ?>


            <div class="form-group">
                <?= Html::submitButton('Отправить', ['class' => 'btn btn-primary', 'name' => 'order2-button']) ?>
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
