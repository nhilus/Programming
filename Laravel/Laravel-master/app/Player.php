<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Player extends Model
{
    public function cars(){
        return $this->hasMany(Car::class);
    }

    public function address(){
        return $this->belongsTo(Address::class);
    }
}

