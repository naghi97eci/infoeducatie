<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class Orarelevi extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('Orarstudenti', function (Blueprint $table) {
            $table->increments('ID');
            $table->text('Clasa');
            $table->text('Diriginte');
            $table->text('Ora');
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
        Schema::drop('Orarstudenti');
    }
}
