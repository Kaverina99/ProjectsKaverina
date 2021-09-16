<?php

namespace app\controllers;

use app\models\Chat;
use app\models\Login;
use app\models\Logout;
use app\models\Message;
use app\models\Myorders;
use app\models\Type1;
use app\models\Type2;
use app\models\Type3;
use app\models\Type4;
use app\models\Type5;
use app\models\Type6;
use app\models\Updatecab;
use app\models\User;
use app\models\Zakaz;
use phpDocumentor\Reflection\Types\Null_;
use Yii;
use yii\base\BaseObject;
use yii\data\ActiveDataProvider;
use yii\data\Pagination;
use yii\filters\AccessControl;
use yii\web\Controller;
use yii\web\Response;
use yii\filters\VerbFilter;
use app\models\Signup;
use app\models\ContactForm;

class SotrudnikiController extends Controller
{

    public $layout = 'mainsotr';

    /**
     * {@inheritdoc}
     */
    public function behaviors()
    {
        return [
            'access' => [
                'class' => AccessControl::className(),
                'only' => ['logout'],
                'rules' => [
                    [
                        'actions' => ['logout'],
                        'allow' => true,
                        'roles' => ['@'],
                    ],
                ],
            ],
            'verbs' => [
                'class' => VerbFilter::className(),
                'actions' => [
                    'logout' => ['post'],
                ],
            ],
        ];
    }

    /**
     * {@inheritdoc}
     */
    public function actions()
    {
        return [
            'error' => [
                'class' => 'yii\web\ErrorAction',
            ],
            'captcha' => [
                'class' => 'yii\captcha\CaptchaAction',
                'fixedVerifyCode' => YII_ENV_TEST ? 'testme' : null,
            ],
        ];
    }

    /**
     * Displays homepage.
     *
     * @return string
     */
    public function actionIndex()
    {
        $this->layout = 'mainsotr';
        return $this->render('index');
    }

    public function actionRegions()
    {
        return $this->render('regions');
    }

    public function actionServis()
    {
        return $this->render('servis');
    }

    public function actionProduct()
    {
        return $this->render('product');
    }


    public function actionHistory()
    {
        return $this->render('history');
    }
    public function actionOffice()
    {
        if(!Yii::$app->user->isGuest)
        {
            return $this->render('logout');
        }

        return $this->render('office');
    }


    public function actionProduct1()
    {
        return $this->render('product1');
    }

    public function actionProduct2()
    {
        return $this->render('product2');
    }

    public function actionProduct3()
    {
        return $this->render('product3');
    }

    public function actionProduct4()
    {
        return $this->render('product4');
    }

    public function actionProduct5()
    {
        return $this->render('product5');
    }

    public function actionProduct6()
    {
        return $this->render('product6');
    }

    public function actionSertif()
    {
        return $this->render('sertif');
    }

    public function actionPatents()
    {
        return $this->render('patents');
    }

    /**
     * Displays contact page.
     *
     * @return Response|string
     */
    public function actionContact()
    {
        $model = new ContactForm();
        if ($model->load(Yii::$app->request->post()) && $model->contact(Yii::$app->params['adminEmail'])) {
            Yii::$app->session->setFlash('contactFormSubmitted');

            return $this->refresh();
        }
        return $this->render('contact', [
            'model' => $model,
        ]);
    }



    public function actionSignup()
    {
        $model = new Signup();
        if(isset($_POST['Signup'])){
            $model->attributes = Yii::$app->request->post('Signup');

            if($model->validate() && $model->signup())
                return $this->goHome();
        }
        return $this->render('signup', ['model'=>$model]);
    }

    public function actionLogin(){

        $login_model = new Login();

        if (Yii::$app->request->post('Login')){
            $login_model->attributes = Yii::$app->request->post('Login');

            if ($login_model->validate())
            {
                Yii::$app->user->login($login_model->getUser());
                return $this->goHome();

            }
        }

        return $this->render('login', ['login_model'=>$login_model]);


    }
    public function actionLogout()
    {

        $model = new Logout();
        return $this->render('logout', [
            'model' => $model,
        ]);
    }

    public function actionOff()
    {
        return $this->render('off');
    }


    public function actionOrders()
    {
        $query = Zakaz::find();

        $dataProvider = new ActiveDataProvider([
            'query' => $query,
            'pagination' => [
                'pageSize' => 7,
            ],
        ]);

        return $this->render('orders', ['dataProvider'=>$dataProvider]);
    }

    public function actionMyorders()
    {
        $query = Zakaz::find()->where(['sotrudnikFK' => Yii::$app->user->identity->getId()]);

        $dataProvider = new ActiveDataProvider([
            'query' => $query,
            'pagination' => [
                'pageSize' => 7,
            ],
        ]);

        return $this->render('myorders', ['dataProvider'=>$dataProvider]);
    }

    public function actionView($id)
    {
        $model = Zakaz::findOne($id);


        $model2 = Type1::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
        if ($model2 == NULL)
            $model2 = Type2::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
        if ($model2 == NULL)
            $model2 = Type3::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
        if ($model2 == NULL)
            $model2 = Type4::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
        if ($model2 == NULL)
            $model2 = Type5::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);
        if ($model2 == NULL)
            $model2 = Type6::findOne(Type1::find()->asArray()->where(['zakazFK' => $id])->all()[0][id]);

        if ($model->load(Yii::$app->request->post()))
        {
            $model->save();
            return $this->render('view', ['id' => $id, 'model'=>$model, 'model2'=>$model2]);
        }

        return $this->render('view', ['model'=>$model, 'model2'=>$model2]);

    }


    public function actionCabinet()
    {
        $model = User::findOne(Yii::$app->user->identity->getId());
        return $this->render('cabinet', ['model'=>$model]);
    }

    public function actionUpdatecab()
    {
        $model = User::findOne(Yii::$app->user->identity->getId());
        if ($model->load(Yii::$app->request->post()))
        {
            $model->save();
            return $this->render('cabinet', ['model'=>$model]);
        }
        return $this->render('updatecab', ['model'=>$model]);

    }


    public function actionMessage()
    {
        $rows = Chat::find()->where(['sotrudnikFK' => Yii::$app->user->identity->getId(), 'clientFK' => 6])->all();

        $model = new Message();
        if(isset($_POST['Message'])){
            $model->attributes = Yii::$app->request->post('Message');
            if($model->validate() && $model->message()) {
                $rows = Chat::find()->where(['sotrudnikFK' => Yii::$app->user->identity->getId(), 'clientFK' => 6])->all();
                $model->message =' ';
                return $this->render('message', ['rows'=>$rows, 'model'=>$model]);
            }
        }

        return $this->render('message', ['rows'=>$rows, 'model'=>$model]);

    }


    public function actionVorder()
    {
        return $this->render('vorder');

    }
}


















