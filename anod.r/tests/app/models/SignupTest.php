<?php

namespace app\models;

use PHPUnit\Framework\TestCase;

class SignupTest extends TestCase
{
    public function test1()
    {
        $ph = 4;
        $phh = \app\models\Signup::signup2(2);

        $this->assertEquals($ph, $phh);
    }



}
