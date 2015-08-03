<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Orarprofesori extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Orarprof', function (Blueprint $table) {
            $table->increments('ID');
            $table->text('Ora');
            $table->text('Profesor');
            $table->text('Materie');
            $table->text('Luni');
            $table->text('Marti');
            $table->text('Miercuri');
            $table->text('Joi');
            $table->text('Vineri');
         

            
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::drop('Orarprof');
    }
}
