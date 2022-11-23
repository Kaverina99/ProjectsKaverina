<?php

namespace app\controllers;

use Yii;
use yii\filters\AccessControl;
use yii\web\Controller;
use yii\web\Response;
use yii\filters\VerbFilter;
use app\models\AddTagForm;
use app\models\Tag;

class TagController extends Controller
{
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

    public function actionIndex()
    {
        $model = new AddTagForm();
        if ( $model->load(Yii::$app->request->post()) ) {
            $data = Yii::$app->request->post()['AddTagForm'];
            $addtag = new Tag();
            $addtag->title = $data['title'];
            $addtag->description = $data['description'];
            $addtag->alias = $data['alias'];
            $addtag->save();

            return $this->render('index', ['model' => $model]);
        }
        return $this->render('index', ['model' => $model]);
    }


    public function actionView()
    {
        $alias = \Yii::$app->request->get('alias'); 
        $tag = \app\models\Tag::find()->where(['alias' => $alias])->one();
        $post_ids = \app\models\TagPost::find()->select('post_FK')->where(['tag_FK' => $tag['id']])->all();

        foreach ($post_ids as $key => $value)
            $ids[] = $value['post_FK'];
        
        $posts[] = \app\models\Posts::find()->select('*')->asArray()->where(['id' => $ids])->orderBy(['datetime' => SORT_DESC])->all();


        return $this->render('single', ['tag' => $tag, 'posts' => $posts]);
    }

}
