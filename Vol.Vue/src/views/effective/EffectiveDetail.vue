<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/effective/EffectiveDetail.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/effective/EffectiveDetail.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'ID',
                    footer: "Foots",
                    cnName: '行为列表',
                    name: 'EffectiveDetail',
                    url: "/EffectiveDetail/",
                    sortName: "ID"
                },
                extend: extend,
                editFormFields: {},
                editFormOptions: [],
                searchFormFields: {"TARGET_MODEL":""},
                searchFormOptions: [[{"title":"目标模型","field":"TARGET_MODEL","type":"text"}]],
                columns: [{field:'ACTION',title:'动作类',type:'short',bind:{ key:'actionBehavior',data:[]},width:90,align:'left',sortable:true},
                       {field:'ACTION_VALUE',title:'动作值',type:'string',width:220,align:'left'},
                       {field:'DESCRIPTION',title:'效果描述',type:'string',width:220,align:'left'},
                       {field:'EFFECT_KEY',title:'BIM方法',type:'string',width:220,align:'left'},
                       {field:'EFFECT_VALUE',title:'行为取值',type:'string',width:90,align:'left'},
                       {field:'ENABLE_FLAG',title:'有效标识',type:'short',width:90,align:'left'},
                       {field:'MAIN_ID',title:'子场景',type:'int',width:90,require:true,align:'left'},
                       {field:'ORDER',title:'效果排序',type:'short',width:90,align:'left'},
                       {field:'TARGET_MODEL',title:'目标模型',type:'string',width:90,align:'left'}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
